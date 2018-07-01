using System;

namespace HatTASUI
{
    public class Metadata
    {
        public string Name { get; set; }
        public TASType Type { get; set; }
        public int Length { get; set; }
        public float FPS { get; set; }
        
        public Metadata()
        {
            Name = "Generic TAS";
            Type = TASType.IL;
            Length = 10000;
            FPS = 60;
        }

        public override string ToString()
        {
            var result = "name: " + Name + "\r\n";
            result += "type: " + Type.ToString() + "\r\n";
            result += "length: " + Length + "\r\n";
            result += "fps: " + FPS + "\r\n";
            return result;
        }

        public void UpdateFromString(string line)
        {
            var split = line.Split(new string[] { ": " }, 2, StringSplitOptions.None);
            var label = split[0];
            if (label == "name")
                Name = split[1];
            else if (label == "type")
                Type = (TASType)Enum.Parse(typeof(TASType), split[1]);
            else if (label == "length")
                Length = int.Parse(split[1]);
            else if (label == "fps")
                FPS = float.Parse(split[1]);
        }

        public Metadata Clone()
        {
            var newMetadata = new Metadata();
            newMetadata.Name = Name;
            newMetadata.Type = Type;
            newMetadata.Length = Length;
            newMetadata.FPS = FPS;
            return newMetadata;
        }
    }

    public enum TASType
    {
        IL, immediate, fullgame
    }
}
