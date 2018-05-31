using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HatTASUI
{
    public static class SaveToFile
    {
        public static string FileName;

        public static void SaveAs(List<Frame> frames, Metadata metadata)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.FileName = metadata.Name;
                dialog.Filter = "Hat TAS File (*.htas)|*.htas|All Files (*.*)|*.*";
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                    Save(frames, metadata);
                }
            }
        }

        public static void Save(List<Frame> frames, Metadata metadata)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                SaveAs(frames, metadata);
                return;
            }

            using (var file = new StreamWriter(FileName))
            {
                file.WriteLine(metadata.ToString());
                foreach (var frame in frames)
                {
                    file.WriteLine(frame.ToString());
                }
            }
        }
    }
}
