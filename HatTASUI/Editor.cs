using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HatTASUI
{
    public partial class Editor : Form
    {
        public const int STICK_MAX = 65535;

        private int _CurrentFrame = 0;

        public int CurrentFrameNumber
        {
            get
            {
                return _CurrentFrame;
            }
            set
            {
                var frameIndex = Frames.FirstOrDefault(x => x.FrameNumber == value);
                if (frameIndex != null)
                {
                    UpdatePreviousFrame(value);
                    _CurrentFrame = value;
                    grpInputs.Enabled = true;
                    btnRemoveFrame.Enabled = true;
                    btnMoveFrame.Enabled = true;
                }
                else
                {
                    PreviousFrameState = new FrameState();
                    _CurrentFrame = 0;
                    grpInputs.Enabled = false;
                    btnRemoveFrame.Enabled = false;
                    btnMoveFrame.Enabled = false;
                }
                SwitchToCurrentFrame();
            }
        }
        public Frame CurrentFrame
        {
            get
            {
                return Frames.FirstOrDefault(x => x.FrameNumber == CurrentFrameNumber);
            }
        }
        public FrameState PreviousFrameState { get; set; }
        public List<Frame> Frames { get; set; }

        public Metadata Metadata { get; set; }

        private int _LeftX;
        private int _LeftY;
        private int _RightX;
        private int _RightY;

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
                if (UpdateDictionary("LX", LeftX))
                    txtLeftX.BackColor = Color.Yellow;
                else
                    txtLeftX.BackColor = Color.White;
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
                if (UpdateDictionary("LY", LeftY))
                    txtLeftY.BackColor = Color.Yellow;
                else
                    txtLeftY.BackColor = Color.White;
            }
        }
        public int RightX
        {
            get
            {
                return _RightX;
            }
            set
            {
                _RightX = Math.Max(Math.Min(value, STICK_MAX), 0);
                txtRightX.Value = _RightX;
                trkRightX.Value = _RightX;
                UpdateStickDrawings();
                if (UpdateDictionary("RX", RightX))
                    txtRightX.BackColor = Color.Yellow;
                else
                    txtRightX.BackColor = Color.White;
            }
        }
        public int RightY
        {
            get
            {
                return _RightY;
            }
            set
            {
                _RightY = Math.Max(Math.Min(value, STICK_MAX), 0);
                txtRightY.Value = _RightY;
                trkRightY.Value = -_RightY;
                UpdateStickDrawings();
                if (UpdateDictionary("RY", RightY))
                    txtRightY.BackColor = Color.Yellow;
                else
                    txtRightY.BackColor = Color.White;
            }
        }

        private Bitmap LeftStickDrawArea;
        private Bitmap RightStickDrawArea;

        public Editor()
        {
            InitializeComponent();
            InitializeStickDrawings();
            Frames = new List<Frame>();
            CurrentFrameNumber = 0;
            Metadata = new Metadata();
        }

        private void InitializeStickDrawings()
        {
            LeftStickDrawArea = new Bitmap(leftStick.Width, leftStick.Height);
            leftStick.Image = LeftStickDrawArea;
            RightStickDrawArea = new Bitmap(rightStick.Width, rightStick.Height);
            rightStick.Image = RightStickDrawArea;
        }

        private void UpdateStickDrawings()
        {
            var leftG = Graphics.FromImage(LeftStickDrawArea);
            DrawStick(LeftX, LeftY, LeftStickDrawArea.Width, LeftStickDrawArea.Height, leftG);
            leftG.Dispose();
            leftStick.Image = LeftStickDrawArea;

            var rightG = Graphics.FromImage(RightStickDrawArea);
            DrawStick(RightX, RightY, RightStickDrawArea.Width, RightStickDrawArea.Height, rightG);
            rightG.Dispose();
            rightStick.Image = RightStickDrawArea;
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

        private void SwitchToCurrentFrame()
        {
            if (CurrentFrame != null && CurrentFrame.Changes.ContainsKey("LX"))
                LeftX = CurrentFrame.Changes["LX"];
            else
                LeftX = PreviousFrameState.Inputs["LX"];
            if (CurrentFrame != null && CurrentFrame.Changes.ContainsKey("LY"))
                LeftY = CurrentFrame.Changes["LY"];
            else
                LeftY = PreviousFrameState.Inputs["LY"];
            if (CurrentFrame != null && CurrentFrame.Changes.ContainsKey("RX"))
                RightX = CurrentFrame.Changes["RX"];
            else
                RightX = PreviousFrameState.Inputs["RX"];
            if (CurrentFrame != null && CurrentFrame.Changes.ContainsKey("RY"))
                RightY = CurrentFrame.Changes["RY"];
            else
                RightY = PreviousFrameState.Inputs["RY"];

            UpdateCheckBox(chkA, "A");
            UpdateCheckBox(chkB, "B");
            UpdateCheckBox(chkX, "X");
            UpdateCheckBox(chkY, "Y");
            UpdateCheckBox(chkStart, "START");
            UpdateCheckBox(chkLB, "LB");
            UpdateCheckBox(chkRB, "RB");
            UpdateCheckBox(chkLT, "LT");
            UpdateCheckBox(chkRT, "RT");
            UpdateCheckBox(chkSelect, "SELECT");
            UpdateCheckBox(chkLeft, "LEFT");
            UpdateCheckBox(chkDown, "DOWN");
            UpdateCheckBox(chkUp, "UP");
            UpdateCheckBox(chkRight, "RIGHT");

            if (CurrentFrame != null)
                txtComment.Text = CurrentFrame.Comment;
            else
                txtComment.Text = "";
        }

        private void UpdateCheckBox(CheckBox chk, string input)
        {
            if (CurrentFrame != null && CurrentFrame.Changes.ContainsKey(input))
                chk.Checked = CurrentFrame.Changes[input] == 1;
            else
                chk.Checked = PreviousFrameState.Inputs[input] == 1;
            UpdateButton(chk, input);
        }

        private void ResetLeftStick()
        {
            LeftX = PreviousFrameState.Inputs["LX"];
            LeftY = PreviousFrameState.Inputs["LY"];
        }

        private void ResetRightStick()
        {
            RightX = PreviousFrameState.Inputs["RX"];
            RightY = PreviousFrameState.Inputs["RY"];
        }

        private void UpdateLeftStick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftX = (int)(((double)e.X / leftStick.Width) * STICK_MAX);
                LeftY = (int)(((double)e.Y / leftStick.Width) * STICK_MAX);
            }
        }

        private void UpdateRightStick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RightX = (int)(((double)e.X / rightStick.Width) * STICK_MAX);
                RightY = (int)(((double)e.Y / rightStick.Width) * STICK_MAX);
            }
        }

        private void UpdatePreviousFrame(int upToFrame)
        {
            PreviousFrameState = new FrameState();
            var upToIndex = IndexOfFrame(upToFrame);
            for (var index = 0; index < upToIndex; index++)
            {
                PreviousFrameState.UpdateFromChanges(Frames[index].Changes);
            }
        }

        private int IndexOfFrame(int frameNumber)
        {
            var index = 0;
            while (index < Frames.Count && Frames[index].FrameNumber < frameNumber)
            {
                index++;
            }
            return index;
        }

        private bool UpdateDictionary(string input, int value)
        {
            if (CurrentFrame != null)
            {
                var previousValue = PreviousFrameState.Inputs[input];
                if (value != previousValue)
                {
                    CurrentFrame.Changes[input] = value;
                    return true;
                }
                CurrentFrame.Changes.Remove(input);
            }
            return false;
        }

        private void btnLeftLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = STICK_MAX / 2;
        }

        private void btnRightLeft_Click(object sender, EventArgs e)
        {
            RightX = 0;
            RightY = STICK_MAX / 2;
        }

        private void btnLeftDown_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX / 2;
            LeftY = STICK_MAX;
        }

        private void btnRightDown_Click(object sender, EventArgs e)
        {
            RightX = STICK_MAX / 2;
            RightY = STICK_MAX;
        }

        private void btnLeftUp_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX / 2;
            LeftY = 0;
        }

        private void btnRightUp_Click(object sender, EventArgs e)
        {
            RightX = STICK_MAX / 2;
            RightY = 0;
        }

        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX;
            LeftY = STICK_MAX / 2;
        }

        private void btnRightRight_Click(object sender, EventArgs e)
        {
            RightX = STICK_MAX;
            RightY = STICK_MAX / 2;
        }

        private void btnLeftDownLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = STICK_MAX;
        }

        private void btnRightDownLeft_Click(object sender, EventArgs e)
        {
            RightX = 0;
            RightY = STICK_MAX;
        }

        private void btnLeftDownRight_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX;
            LeftY = STICK_MAX;
        }

        private void btnRightDownRight_Click(object sender, EventArgs e)
        {
            RightX = STICK_MAX;
            RightY = STICK_MAX;
        }

        private void btnLeftUpLeft_Click(object sender, EventArgs e)
        {
            LeftX = 0;
            LeftY = 0;
        }

        private void btnRightUpLeft_Click(object sender, EventArgs e)
        {
            RightX = 0;
            RightY = 0;
        }

        private void btnLeftUpRight_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX;
            LeftY = 0;
        }

        private void btnRightUpRight_Click(object sender, EventArgs e)
        {
            RightX = STICK_MAX;
            RightY = 0;
        }

        private void btnLeftReset_Click(object sender, EventArgs e)
        {
            ResetLeftStick();
        }

        private void btnRightReset_Click(object sender, EventArgs e)
        {
            ResetRightStick();
        }

        private void btnLeftNeutral_Click(object sender, EventArgs e)
        {
            LeftX = STICK_MAX / 2;
            LeftY = STICK_MAX / 2;
        }

        private void btnRightNeutral_Click(object sender, EventArgs e)
        {
            RightX = STICK_MAX / 2;
            RightY = STICK_MAX / 2;
        }

        private void txtLeftY_ValueChanged(object sender, EventArgs e)
        {
            LeftY = (int)txtLeftY.Value;
        }

        private void txtRightY_ValueChanged(object sender, EventArgs e)
        {
            RightY = (int)txtRightY.Value;
        }

        private void txtLeftX_ValueChanged(object sender, EventArgs e)
        {
            LeftX = (int)txtLeftX.Value;
        }

        private void txtRightX_ValueChanged(object sender, EventArgs e)
        {
            RightX = (int)txtRightX.Value;
        }

        private void trkLeftX_ValueChanged(object sender, EventArgs e)
        {
            LeftX = trkLeftX.Value;
        }

        private void trkRightX_ValueChanged(object sender, EventArgs e)
        {
            RightX = trkRightX.Value;
        }

        private void trkLeftY_ValueChanged(object sender, EventArgs e)
        {
            LeftY = -trkLeftY.Value;
        }

        private void trkRightY_ValueChanged(object sender, EventArgs e)
        {
            RightY = -trkRightY.Value;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            UpdateStickDrawings();
            SwitchToCurrentFrame();
        }

        private void leftStick_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateLeftStick(e);
        }

        private void rightStick_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateRightStick(e);
        }

        private void leftStick_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateLeftStick(e);
        }

        private void rightStick_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateRightStick(e);
        }

        private bool AddFrame(Frame frame)
        {
            var frameNumber = frame.FrameNumber;
            var insertIndex = IndexOfFrame(frameNumber);
            if (insertIndex >= Frames.Count || Frames[insertIndex].FrameNumber != frameNumber)
            {
                Frames.Insert(insertIndex, frame);
                framesList.Items.Insert(insertIndex, frameNumber);
                framesList.SelectedIndex = insertIndex;
                return true;
            }
            MessageBox.Show("This frame already exists.", "Frame Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnAddFrame_Click(object sender, EventArgs e)
        {
            var frameNumber = (int)newFrameSelect.Value;
            var frame = new Frame(frameNumber);
            if (AddFrame(frame) && Frames.Count > 0)
                newFrameSelect.Value = Frames.Last().FrameNumber + 1;
        }

        private void btnRemoveFrame_Click(object sender, EventArgs e)
        {
            var index = framesList.SelectedIndex;
            if (index >= 0 && index < Frames.Count)
            {
                Frames.RemoveAt(index);
                framesList.Items.RemoveAt(index);
            }
        }

        private void btnMoveFrame_Click(object sender, EventArgs e)
        {
            var index = framesList.SelectedIndex;
            if (index >= 0 && index < Frames.Count)
            {
                var previousFrameNumber = Frames[index].FrameNumber;
                var frame = Frames[index].Clone();
                frame.FrameNumber = (int)newFrameSelect.Value;
                if (AddFrame(frame))
                {
                    index = IndexOfFrame(previousFrameNumber);
                    Frames.RemoveAt(index);
                    framesList.Items.RemoveAt(index);
                }
            }
        }

        private void framesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (framesList.SelectedItem != null)
            {
                CurrentFrameNumber = (int)framesList.SelectedItem;
            }
            else
            {
                CurrentFrameNumber = 0;
            }
        }

        private void UpdateButton(CheckBox chk, string input)
        {
            var value = chk.Checked ? 1 : 0;
            if (UpdateDictionary(input, value))
                chk.BackColor = Color.Yellow;
            else
                chk.BackColor = Color.Transparent;
        }

        private void chkA_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkA, "A");
        }

        private void chkB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkB, "B");
        }

        private void chkX_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkX, "X");
        }

        private void chkY_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkY, "Y");
        }

        private void chkStart_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkStart, "START");
        }

        private void chkLB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkLB, "LB");
        }

        private void chkRB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkRB, "RB");
        }

        private void chkLT_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkLT, "LT");
        }

        private void chkRT_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkRT, "RT");
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkSelect, "SELECT");
        }

        private void chkLeft_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkLeft, "LEFT");
        }

        private void chkDown_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkDown, "DOWN");
        }

        private void chkUp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkUp, "UP");
        }

        private void chkRight_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButton(chkRight, "RIGHT");
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if (CurrentFrame != null)
                CurrentFrame.Comment = txtComment.Text;
        }
    }
}
