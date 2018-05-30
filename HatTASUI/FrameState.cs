using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatTASUI
{
    public class FrameState
    {
        public IDictionary<string, int> Inputs { get; set; }

        public FrameState()
        {
            Inputs = new Dictionary<string, int>();
            Inputs["LX"] = Editor.STICK_MAX / 2;
            Inputs["LY"] = Editor.STICK_MAX / 2;
            Inputs["RX"] = Editor.STICK_MAX / 2;
            Inputs["RY"] = Editor.STICK_MAX / 2;
            Inputs["A"] = 0;
            Inputs["B"] = 0;
            Inputs["X"] = 0;
            Inputs["Y"] = 0;
            Inputs["START"] = 0;
            Inputs["LB"] = 0;
            Inputs["RB"] = 0;
            Inputs["LT"] = 0;
            Inputs["RT"] = 0;
            Inputs["SELECT"] = 0;
            Inputs["LEFT"] = 0;
            Inputs["DOWN"] = 0;
            Inputs["UP"] = 0;
            Inputs["RIGHT"] = 0;
        }

        public void UpdateFromChanges(IDictionary<string, int> changes)
        {
            foreach (var key in changes.Keys)
            {
                Inputs[key] = changes[key];
            }
        }
    }
}
