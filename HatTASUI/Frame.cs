using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
