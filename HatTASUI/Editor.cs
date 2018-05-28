﻿using System;
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
        public const int STICK_MAX = 65535;

        public FrameInputs PreviousFrame { get; set; }

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
                _LeftX = Math.Max(Math.Min(value, STICK_MAX), 0);
                txtLeftX.Value = _LeftX;
                trkLeftX.Value = _LeftX;
                UpdateStickDrawings();
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
                _LeftY = Math.Max(Math.Min(value, STICK_MAX), 0);
                txtLeftY.Value = _LeftY;
                trkLeftY.Value = -_LeftY;
                UpdateStickDrawings();
            }
        }

        private Bitmap LeftStickDrawArea;

        public Editor()
        {
            InitializeComponent();

            PreviousFrame = new FrameInputs();

            InitializeStickDrawings();
        }

        private void InitializeStickDrawings()
        {
            LeftStickDrawArea = new Bitmap(leftStick.Width, leftStick.Height);
            leftStick.Image = LeftStickDrawArea;
        }

        private void UpdateStickDrawings()
        {
            var leftG = Graphics.FromImage(LeftStickDrawArea);
            DrawStick(LeftX, LeftY, LeftStickDrawArea.Width, LeftStickDrawArea.Height, leftG);
            leftG.Dispose();
            leftStick.Image = LeftStickDrawArea;
        }

        private void DrawStick(int x, int y, int width, int height, Graphics g)
        {
            g.FillRectangle(Brushes.DarkGray, 0, 0, width, height);
            g.FillEllipse(Brushes.White, 0, 0, width - 1, height - 1);
            using (var pen = new Pen(Brushes.Black))
            {
                g.DrawEllipse(pen, 0, 0, width - 1, height - 1);
            }

            var imageX = ((float)x / STICK_MAX) * width;
            var imageY = ((float)y / STICK_MAX) * height;
            using (var pen = new Pen(Brushes.Black, 3))
            {
                g.DrawLine(pen, width / 2f, height / 2f, imageX, imageY);
            }
            g.FillEllipse(Brushes.Blue, imageX - 5, imageY - 5, 10, 10);
            using (var pen = new Pen(Brushes.Black))
            {
                g.DrawEllipse(pen, imageX - 5, imageY - 5, 10, 10);
            }
        }

        private void ResetFromPreviousFrame()
        {
            ResetLeftStick();
        }

        private void ResetLeftStick()
        {
            LeftX = PreviousFrame.LX;
            LeftY = PreviousFrame.LY;
        }

        private void UpdateLeftStick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftX = (int)(((double)e.X / leftStick.Width) * STICK_MAX);
                LeftY = (int)(((double)e.Y / leftStick.Width) * STICK_MAX);
            }
        }

        private void btnLeftLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = STICK_MAX / 2;
        }

        private void btnLeftDown_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX / 2;
            LeftY = STICK_MAX;
        }

        private void btnLeftUp_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX / 2;
            LeftY = 0;
        }

        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX;
            LeftY = STICK_MAX / 2;
        }

        private void btnLeftDownLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = STICK_MAX;
        }

        private void btnLeftDownRight_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX;
            LeftY = STICK_MAX;
        }

        private void btnLeftUpLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = 0;
        }

        private void btnLeftUpRight_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX;
            LeftY = 0;
        }

        private void btnLeftReset_Click(object sender, EventArgs e)
        {
            ResetLeftStick();
        }

        private void btnLeftNeutral_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX / 2;
            LeftY = STICK_MAX / 2;
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

        private void Editor_Load(object sender, EventArgs e)
        {
            UpdateStickDrawings();
            ResetFromPreviousFrame();
        }

        private void leftStick_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateLeftStick(e);
        }

        private void leftStick_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateLeftStick(e);
        }
    }
}