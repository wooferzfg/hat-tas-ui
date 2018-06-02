using System.Collections.Generic;

namespace HatTASUI
{
    public struct TASFile
    {
        public List<Frame> Frames;
        public Metadata Metadata;
        public string FilePath;

        public TASFile(List<Frame> frames, Metadata metadata, string filePath)
        {
            Frames = frames;
            Metadata = metadata;
            FilePath = filePath;
        }
    }
}
