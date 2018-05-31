using System.Collections.Generic;

namespace HatTASUI
{
    public struct TASFile
    {
        public List<Frame> Frames;
        public Metadata Metadata;

        public TASFile(List<Frame> frames, Metadata metadata)
        {
            Frames = frames;
            Metadata = metadata;
        }
    }
}
