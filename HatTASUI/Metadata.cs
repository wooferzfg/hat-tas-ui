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
    }

    public enum TASType
    {
        IL, FullGame
    }
}
