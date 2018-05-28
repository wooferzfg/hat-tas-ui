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
    public partial class Editor : Form
    {
        private int _LeftX;
        private int _LeftY;

        public int LeftX
        {
            get
            {
                return _LeftX;
            }
            set
            {
                _LeftX = Math.Max(Math.Min(value, 65535), 0);
                txtLeftX.Value = _LeftX;
                trkLeftX.Value = _LeftX;
            }
        }
        public int LeftY
        {
            get
            {
                return _LeftY;
            }
            set
            {
                _LeftY = Math.Max(Math.Min(value, 65535), 0);
                txtLeftY.Value = _LeftY;
                trkLeftY.Value = -_LeftY;
            }
        }

        public Editor()
        {
            InitializeComponent();
        }

        private void btnLeftLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = 32767;
        }

        private void btnLeftDown_Click(object sender, EventArgs e)
        {
            LeftX = 32767;
            LeftY = 65535;
        }

        private void btnLeftUp_Click(object sender, EventArgs e)
        {
            LeftX = 32767;
            LeftY = 0;
        }

        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            LeftX = 65535;
            LeftY = 32767;
        }

        private void btnLeftDownLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = 65535;
        }

        private void btnLeftDownRight_Click(object sender, EventArgs e)
        {
            LeftX = 65535;
            LeftY = 65535;
        }

        private void btnLeftUpLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = 0;
        }

        private void btnLeftUpRight_Click(object sender, EventArgs e)
        {
            LeftX = 65535;
            LeftY = 0;
        }

        private void txtLeftY_ValueChanged(object sender, EventArgs e)
        {
            LeftY = (int)txtLeftY.Value;
        }

        private void txtLeftX_ValueChanged(object sender, EventArgs e)
        {
            LeftX = (int)txtLeftX.Value;
        }

        private void trkLeftX_ValueChanged(object sender, EventArgs e)
        {
            LeftX = trkLeftX.Value;
        }

        private void trkLeftY_ValueChanged(object sender, EventArgs e)
        {
            LeftY = -trkLeftY.Value;
        }
    }
}
