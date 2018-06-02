using System;

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

        public override string ToString()
        {
            var result = "name: " + Name + "\r\n";
            if (Type == TASType.IL)
                result += "type: IL\r\n";
            else if (Type == TASType.FullGame)
                result += "type: fullgame\r\n";
            result += "length: " + Length + "\r\n";
            return result;
        }

        public void UpdateFromString(string line)
        {
            var split = line.Split(new string[] { ": " }, 2, StringSplitOptions.None);
            if (split[0] == "name")
                Name = split[1];
            else if (split[0] == "type")
            {
                if (split[1] == "IL")
                    Type = TASType.IL;
                else if (split[1] == "fullgame")
                    Type = TASType.FullGame;
            }
            else if (split[0] == "length")
                Length = int.Parse(split[1]);
        }

        public Metadata Clone()
        {
            var newMetadata = new Metadata();
            newMetadata.Name = Name;
            newMetadata.Type = Type;
            newMetadata.Length = Length;
            return newMetadata;
        }
    }

    public enum TASType
    {
        IL, FullGame
    }
}
