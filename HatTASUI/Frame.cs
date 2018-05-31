using System;
using System.Collections.Generic;
using System.Linq;

namespace HatTASUI
{
    public class Frame
    {
        public int FrameNumber { get; set; }
        public IDictionary<string, int> Changes { get; set; }
        public string Comment { get; set; }

        public Frame(int frameNumber)
        {
            FrameNumber = frameNumber;
            Changes = new Dictionary<string, int>();
            Comment = string.Empty;
        }

        public Frame Clone()
        {
            var newFrame = new Frame(FrameNumber);
            newFrame.Changes = Changes.ToDictionary(x => x.Key, x => x.Value);
            newFrame.Comment = Comment;
            return newFrame;
        }

        public override string ToString()
        {
            var result = FrameNumber.ToString("000000") + ":";
            foreach (var change in Changes)
            {
                if (change.Key == "LX" || change.Key == "LY" || change.Key == "RX" || change.Key == "RY")
                {
                    if (change.Value == Editor.STICK_MAX / 2)
                        result += " ~" + change.Key;
                    else
                        result += " " + change.Key + ":" + change.Value;
                }
                else if (change.Value == 1)
                {
                    result += " " + change.Key;
                }
                else
                {
                    result += " ~" + change.Key;
                }
            }
            if (!string.IsNullOrEmpty(Comment))
            {
                result += new string(' ', Math.Max(35 - result.Length, 0))
                          + " // " + Comment;
            }
            return result;
        }

        public static Frame FromString(string line)
        {
            var split = line.Split(new string[] { ": " }, 2, StringSplitOptions.None);
            var frame = new Frame(int.Parse(split[0]));

            var commentSplit = split[1].Split(new string[] { "//" }, 2, StringSplitOptions.None);
            if (commentSplit.Length > 1)
                frame.Comment = commentSplit[1].Trim();

            var tokens = commentSplit[0].Trim().Split(' ');
            var defaults = (new FrameState()).Inputs;
            foreach (var token in tokens)
            {
                var tokenSplit = token.Split(':');
                if (tokenSplit.Length > 1)
                {
                    frame.Changes.Add(tokenSplit[0], int.Parse(tokenSplit[1]));
                }
                else if (token.StartsWith("~"))
                {
                    var input = token.Substring(1);
                    frame.Changes.Add(input, defaults[input]);
                }
                else
                {
                    frame.Changes.Add(token, 1);
                }
            }

            return frame;
        }
    }
}
