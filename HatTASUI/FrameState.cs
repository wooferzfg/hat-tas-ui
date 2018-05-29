using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatTASUI
{
    public class FrameState
    {
        public int LX { get; set; }
        public int LY { get; set; }
        public int RX { get; set; }
        public int RY { get; set; }
        public bool A { get; set; }
        public bool B { get; set; }
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool START { get; set; }
        public bool LB { get; set; }
        public bool RB { get; set; }
        public bool LT { get; set; }
        public bool RT { get; set; }
        public bool SELECT { get; set; }
        public bool LEFT { get; set; }
        public bool DOWN { get; set; }
        public bool UP { get; set; }
        public bool RIGHT { get; set; }

        public FrameState()
        {
            LX = Editor.STICK_MAX / 2;
            LY = Editor.STICK_MAX / 2;
            RX = Editor.STICK_MAX / 2;
            RY = Editor.STICK_MAX / 2;
            A = false;
            B = false;
            X = false;
            Y = false;
            START = false;
            LB = false;
            RB = false;
            LT = false;
            RT = false;
            SELECT = false;
            LEFT = false;
            DOWN = false;
            UP = false;
            RIGHT = false;
        }

        public void UpdateFromChanges(IDictionary<string, int> changes)
        {
            if (changes.ContainsKey("LX"))
                LX = changes["LX"];
            if (changes.ContainsKey("LY"))
                LY = changes["LY"];
            if (changes.ContainsKey("RX"))
                RX = changes["RX"];
            if (changes.ContainsKey("RY"))
                RY = changes["RY"];
            if (changes.ContainsKey("A"))
                A = changes["A"] == 1;
            if (changes.ContainsKey("B"))
                B = changes["B"] == 1;
            if (changes.ContainsKey("X"))
                X = changes["X"] == 1;
            if (changes.ContainsKey("Y"))
                Y = changes["Y"] == 1;
            if (changes.ContainsKey("LB"))
                LB = changes["LB"] == 1;
            if (changes.ContainsKey("RB"))
                RB = changes["RB"] == 1;
            if (changes.ContainsKey("LT"))
                LT = changes["LT"] == 1;
            if (changes.ContainsKey("RT"))
                RT = changes["RT"] == 1;
            if (changes.ContainsKey("START"))
                START = changes["START"] == 1;
            if (changes.ContainsKey("SELECT"))
                SELECT = changes["SELECT"] == 1;
            if (changes.ContainsKey("UP"))
                UP = changes["UP"] == 1;
            if (changes.ContainsKey("RIGHT"))
                RIGHT = changes["RIGHT"] == 1;
            if (changes.ContainsKey("DOWN"))
                DOWN = changes["DOWN"] == 1;
            if (changes.ContainsKey("LEFT"))
                LEFT = changes["LEFT"] == 1;
        }
    }
}
