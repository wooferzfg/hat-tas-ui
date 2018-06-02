using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatTASUI
{
    public partial class MetadataDialog : Form
    {
        public Metadata Metadata { get; set; }

        public MetadataDialog(Metadata metadata)
        {
            InitializeComponent();

            Metadata = metadata;
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            txtName.Text = Metadata.Name;
            cmbType.SelectedIndex = (int)Metadata.Type;
            txtLength.Value = Metadata.Length;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Metadata.Name = txtName.Text;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metadata.Type = (TASType)cmbType.SelectedIndex;
        }

        private void txtLength_ValueChanged(object sender, EventArgs e)
        {
            Metadata.Length = (int)txtLength.Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
