namespace HatTASUI
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.framesList = new System.Windows.Forms.ListBox();
            this.newFrameSelect = new System.Windows.Forms.NumericUpDown();
            this.btnAddFrame = new System.Windows.Forms.Button();
            this.btnRemoveFrame = new System.Windows.Forms.Button();
            this.lblNewFrame = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpLeftStick = new System.Windows.Forms.GroupBox();
            this.grpRightStick = new System.Windows.Forms.GroupBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkX = new System.Windows.Forms.CheckBox();
            this.chkY = new System.Windows.Forms.CheckBox();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.chkLB = new System.Windows.Forms.CheckBox();
            this.chkRB = new System.Windows.Forms.CheckBox();
            this.chkLT = new System.Windows.Forms.CheckBox();
            this.chkRT = new System.Windows.Forms.CheckBox();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.chkDown = new System.Windows.Forms.CheckBox();
            this.chkUp = new System.Windows.Forms.CheckBox();
            this.chkRight = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trkLeftX = new System.Windows.Forms.TrackBar();
            this.txtLeftX = new System.Windows.Forms.TextBox();
            this.trkLeftY = new System.Windows.Forms.TrackBar();
            this.txtLeftY = new System.Windows.Forms.TextBox();
            this.leftStick = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFrameSelect)).BeginInit();
            this.grpInputs.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpLeftStick.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftStick)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.framesList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newFrameSelect, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddFrame, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNewFrame, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveFrame, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpInputs, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 597);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // framesList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.framesList, 3);
            this.framesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framesList.FormattingEnabled = true;
            this.framesList.Items.AddRange(new object[] {
            "Frame 1",
            "Frame 2",
            "Frame 3",
            "Frame 1",
            "Frame 2",
            "Frame 3",
            "Frame 1",
            "Frame 2",
            "Frame 3",
            "Frame 1",
            "Frame 2",
            "Frame 3",
            "Frame 1",
            "Frame 2",
            "Frame 3",
            "Frame 1",
            "Frame 2",
            "Frame 3"});
            this.framesList.Location = new System.Drawing.Point(3, 3);
            this.framesList.Name = "framesList";
            this.framesList.Size = new System.Drawing.Size(317, 394);
            this.framesList.TabIndex = 0;
            // 
            // newFrameSelect
            // 
            this.newFrameSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newFrameSelect.Location = new System.Drawing.Point(120, 433);
            this.newFrameSelect.Name = "newFrameSelect";
            this.newFrameSelect.Size = new System.Drawing.Size(102, 20);
            this.newFrameSelect.TabIndex = 1;
            // 
            // btnAddFrame
            // 
            this.btnAddFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFrame.Location = new System.Drawing.Point(228, 432);
            this.btnAddFrame.Name = "btnAddFrame";
            this.btnAddFrame.Size = new System.Drawing.Size(92, 23);
            this.btnAddFrame.TabIndex = 2;
            this.btnAddFrame.Text = "Add Frame";
            this.btnAddFrame.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFrame
            // 
            this.btnRemoveFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnRemoveFrame, 3);
            this.btnRemoveFrame.Location = new System.Drawing.Point(3, 403);
            this.btnRemoveFrame.Name = "btnRemoveFrame";
            this.btnRemoveFrame.Size = new System.Drawing.Size(317, 23);
            this.btnRemoveFrame.TabIndex = 3;
            this.btnRemoveFrame.Text = "Remove Selected Frame";
            this.btnRemoveFrame.UseVisualStyleBackColor = true;
            // 
            // lblNewFrame
            // 
            this.lblNewFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewFrame.AutoSize = true;
            this.lblNewFrame.Location = new System.Drawing.Point(3, 437);
            this.lblNewFrame.Name = "lblNewFrame";
            this.lblNewFrame.Size = new System.Drawing.Size(111, 13);
            this.lblNewFrame.TabIndex = 4;
            this.lblNewFrame.Text = "New Frame Number:";
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.tableLayoutPanel2);
            this.grpInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInputs.Location = new System.Drawing.Point(326, 3);
            this.grpInputs.Name = "grpInputs";
            this.tableLayoutPanel1.SetRowSpan(this.grpInputs, 3);
            this.grpInputs.Size = new System.Drawing.Size(577, 452);
            this.grpInputs.TabIndex = 5;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Inputs on Selected Frame";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grpLeftStick, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpRightStick, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpButtons, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 433);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grpLeftStick
            // 
            this.grpLeftStick.Controls.Add(this.tableLayoutPanel4);
            this.grpLeftStick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLeftStick.Location = new System.Drawing.Point(3, 3);
            this.grpLeftStick.Name = "grpLeftStick";
            this.grpLeftStick.Size = new System.Drawing.Size(279, 219);
            this.grpLeftStick.TabIndex = 0;
            this.grpLeftStick.TabStop = false;
            this.grpLeftStick.Text = "Left Stick";
            // 
            // grpRightStick
            // 
            this.grpRightStick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRightStick.Location = new System.Drawing.Point(288, 3);
            this.grpRightStick.Name = "grpRightStick";
            this.grpRightStick.Size = new System.Drawing.Size(280, 219);
            this.grpRightStick.TabIndex = 1;
            this.grpRightStick.TabStop = false;
            this.grpRightStick.Text = "Right Stick";
            // 
            // grpButtons
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.grpButtons, 2);
            this.grpButtons.Controls.Add(this.tableLayoutPanel3);
            this.grpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpButtons.Location = new System.Drawing.Point(3, 228);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(565, 202);
            this.grpButtons.TabIndex = 2;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Buttons";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.chkRight, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkUp, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkDown, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkLeft, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkSelect, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkRT, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkLT, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkRB, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkLB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.chkStart, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkY, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkX, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkB, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkA, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(559, 183);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // chkA
            // 
            this.chkA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkA.AutoSize = true;
            this.chkA.Location = new System.Drawing.Point(3, 21);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(105, 17);
            this.chkA.TabIndex = 0;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkB.AutoSize = true;
            this.chkB.Location = new System.Drawing.Point(114, 21);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(105, 17);
            this.chkB.TabIndex = 1;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkX
            // 
            this.chkX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkX.AutoSize = true;
            this.chkX.Location = new System.Drawing.Point(225, 21);
            this.chkX.Name = "chkX";
            this.chkX.Size = new System.Drawing.Size(105, 17);
            this.chkX.TabIndex = 2;
            this.chkX.Text = "X";
            this.chkX.UseVisualStyleBackColor = true;
            // 
            // chkY
            // 
            this.chkY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkY.AutoSize = true;
            this.chkY.Location = new System.Drawing.Point(336, 21);
            this.chkY.Name = "chkY";
            this.chkY.Size = new System.Drawing.Size(105, 17);
            this.chkY.TabIndex = 3;
            this.chkY.Text = "Y";
            this.chkY.UseVisualStyleBackColor = true;
            // 
            // chkStart
            // 
            this.chkStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStart.AutoSize = true;
            this.chkStart.Location = new System.Drawing.Point(447, 21);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(109, 17);
            this.chkStart.TabIndex = 4;
            this.chkStart.Text = "Start";
            this.chkStart.UseVisualStyleBackColor = true;
            // 
            // chkLB
            // 
            this.chkLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLB.AutoSize = true;
            this.chkLB.Location = new System.Drawing.Point(3, 81);
            this.chkLB.Name = "chkLB";
            this.chkLB.Size = new System.Drawing.Size(105, 17);
            this.chkLB.TabIndex = 5;
            this.chkLB.Text = "LB";
            this.chkLB.UseVisualStyleBackColor = true;
            // 
            // chkRB
            // 
            this.chkRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRB.AutoSize = true;
            this.chkRB.Location = new System.Drawing.Point(114, 81);
            this.chkRB.Name = "chkRB";
            this.chkRB.Size = new System.Drawing.Size(105, 17);
            this.chkRB.TabIndex = 6;
            this.chkRB.Text = "RB";
            this.chkRB.UseVisualStyleBackColor = true;
            // 
            // chkLT
            // 
            this.chkLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLT.AutoSize = true;
            this.chkLT.Location = new System.Drawing.Point(225, 81);
            this.chkLT.Name = "chkLT";
            this.chkLT.Size = new System.Drawing.Size(105, 17);
            this.chkLT.TabIndex = 7;
            this.chkLT.Text = "LT";
            this.chkLT.UseVisualStyleBackColor = true;
            // 
            // chkRT
            // 
            this.chkRT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRT.AutoSize = true;
            this.chkRT.Location = new System.Drawing.Point(336, 81);
            this.chkRT.Name = "chkRT";
            this.chkRT.Size = new System.Drawing.Size(105, 17);
            this.chkRT.TabIndex = 8;
            this.chkRT.Text = "RT";
            this.chkRT.UseVisualStyleBackColor = true;
            // 
            // chkSelect
            // 
            this.chkSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelect.AutoSize = true;
            this.chkSelect.Location = new System.Drawing.Point(447, 81);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(109, 17);
            this.chkSelect.TabIndex = 9;
            this.chkSelect.Text = "Select";
            this.chkSelect.UseVisualStyleBackColor = true;
            // 
            // chkLeft
            // 
            this.chkLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(3, 143);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(105, 17);
            this.chkLeft.TabIndex = 10;
            this.chkLeft.Text = "D Left";
            this.chkLeft.UseVisualStyleBackColor = true;
            // 
            // chkDown
            // 
            this.chkDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDown.AutoSize = true;
            this.chkDown.Location = new System.Drawing.Point(114, 143);
            this.chkDown.Name = "chkDown";
            this.chkDown.Size = new System.Drawing.Size(105, 17);
            this.chkDown.TabIndex = 11;
            this.chkDown.Text = "D Down";
            this.chkDown.UseVisualStyleBackColor = true;
            // 
            // chkUp
            // 
            this.chkUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUp.AutoSize = true;
            this.chkUp.Location = new System.Drawing.Point(225, 143);
            this.chkUp.Name = "chkUp";
            this.chkUp.Size = new System.Drawing.Size(105, 17);
            this.chkUp.TabIndex = 12;
            this.chkUp.Text = "D Up";
            this.chkUp.UseVisualStyleBackColor = true;
            // 
            // chkRight
            // 
            this.chkRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(336, 143);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(105, 17);
            this.chkRight.TabIndex = 13;
            this.chkRight.Text = "D Right";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.Controls.Add(this.trkLeftX, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtLeftX, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.trkLeftY, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtLeftY, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.leftStick, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(273, 200);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // trkLeftX
            // 
            this.trkLeftX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trkLeftX.Location = new System.Drawing.Point(3, 3);
            this.trkLeftX.Name = "trkLeftX";
            this.trkLeftX.Size = new System.Drawing.Size(129, 32);
            this.trkLeftX.TabIndex = 0;
            // 
            // txtLeftX
            // 
            this.txtLeftX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeftX.Location = new System.Drawing.Point(138, 9);
            this.txtLeftX.Name = "txtLeftX";
            this.txtLeftX.Size = new System.Drawing.Size(63, 20);
            this.txtLeftX.TabIndex = 1;
            // 
            // trkLeftY
            // 
            this.trkLeftY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.trkLeftY.Location = new System.Drawing.Point(216, 41);
            this.trkLeftY.Name = "trkLeftY";
            this.trkLeftY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkLeftY.Size = new System.Drawing.Size(45, 129);
            this.trkLeftY.TabIndex = 2;
            this.trkLeftY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // txtLeftY
            // 
            this.txtLeftY.Location = new System.Drawing.Point(207, 176);
            this.txtLeftY.Name = "txtLeftY";
            this.txtLeftY.Size = new System.Drawing.Size(63, 20);
            this.txtLeftY.TabIndex = 3;
            // 
            // leftStick
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.leftStick, 2);
            this.leftStick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftStick.Location = new System.Drawing.Point(3, 41);
            this.leftStick.Name = "leftStick";
            this.tableLayoutPanel4.SetRowSpan(this.leftStick, 2);
            this.leftStick.Size = new System.Drawing.Size(198, 158);
            this.leftStick.TabIndex = 4;
            this.leftStick.TabStop = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Editor";
            this.Text = "Hat TAS File Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFrameSelect)).EndInit();
            this.grpInputs.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpLeftStick.ResumeLayout(false);
            this.grpButtons.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftStick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox framesList;
        private System.Windows.Forms.NumericUpDown newFrameSelect;
        private System.Windows.Forms.Button btnAddFrame;
        private System.Windows.Forms.Label lblNewFrame;
        private System.Windows.Forms.Button btnRemoveFrame;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpLeftStick;
        private System.Windows.Forms.GroupBox grpRightStick;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkRight;
        private System.Windows.Forms.CheckBox chkUp;
        private System.Windows.Forms.CheckBox chkDown;
        private System.Windows.Forms.CheckBox chkLeft;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.CheckBox chkRT;
        private System.Windows.Forms.CheckBox chkLT;
        private System.Windows.Forms.CheckBox chkRB;
        private System.Windows.Forms.CheckBox chkLB;
        private System.Windows.Forms.CheckBox chkStart;
        private System.Windows.Forms.CheckBox chkY;
        private System.Windows.Forms.CheckBox chkX;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TrackBar trkLeftX;
        private System.Windows.Forms.TextBox txtLeftX;
        private System.Windows.Forms.TrackBar trkLeftY;
        private System.Windows.Forms.TextBox txtLeftY;
        private System.Windows.Forms.PictureBox leftStick;
    }
}

