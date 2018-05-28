using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatTASUI
{
    public class FrameInputs
    {
        public int LX { get; set; }
        public int LY { get; set; }
        public int RX { get; set; }
        public int RY { get; set; }

        public FrameInputs()
        {
            LX = Editor.STICK_MAX / 2;
            LY = Editor.STICK_MAX / 2;
            RX = Editor.STICK_MAX / 2;
            RY = Editor.STICK_MAX / 2;
        }
    }
}
