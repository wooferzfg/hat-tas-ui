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
                result += "     // " + Comment;
            return result;
        }
    }
}
