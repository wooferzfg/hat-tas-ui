using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatTASUI
{
    public class Metadata
    {
        public string Name { get; set; }
        public TASType Type { get; set; }
        public int Length { get; set; }
        
        public Metadata()
        {
            Name = "TAS";
            Type = TASType.IL;
            Length = 10000;
        }
    }

    public enum TASType
    {
        IL, FullGame
    }
}
