using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HatTASUI
{
    public static class SaveToFile
    {
        private static string FilePath;

        public static void SaveAs(List<Frame> frames, Metadata metadata)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.FileName = metadata.Name;
                dialog.Filter = "Hat TAS File (*.htas)|*.htas|All Files (*.*)|*.*";
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    Save(frames, metadata);
                }
            }
        }

        public static void Save(List<Frame> frames, Metadata metadata)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                SaveAs(frames, metadata);
                return;
            }

            using (var file = new StreamWriter(FilePath))
            {
                file.WriteLine(metadata.ToString());
                foreach (var frame in frames)
                {
                    file.WriteLine(frame.ToString());
                }
            }
        }

        public static void ClearFilePath()
        {
            FilePath = "";
        }

        public static void SetFilePath(string filePath)
        {
            FilePath = filePath;
        }
    }
}
