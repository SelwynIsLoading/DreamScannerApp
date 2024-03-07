namespace DreamScannerApp.UserControls
{
    partial class EnrollControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEnrollFingerprint = new Krypton.Toolkit.KryptonButton();
            cbGender = new Krypton.Toolkit.KryptonComboBox();
            cbRoom = new Krypton.Toolkit.KryptonComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbSection = new Krypton.Toolkit.KryptonComboBox();
            tbStudentNum = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            tbMiddleInitial = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            tbLastName = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            tbFname = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbSection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEnrollFingerprint);
            panel1.Controls.Add(cbGender);
            panel1.Controls.Add(cbRoom);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbSection);
            panel1.Controls.Add(tbStudentNum);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbMiddleInitial);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbLastName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbFname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(455, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 690);
            panel1.TabIndex = 0;
            // 
            // btnEnrollFingerprint
            // 
            btnEnrollFingerprint.Anchor = AnchorStyles.Top;
            btnEnrollFingerprint.Location = new Point(141, 593);
            btnEnrollFingerprint.Name = "btnEnrollFingerprint";
            btnEnrollFingerprint.OverrideDefault.Back.Color1 = Color.Red;
            btnEnrollFingerprint.OverrideDefault.Back.Color2 = Color.FromArgb(192, 0, 0);
            btnEnrollFingerprint.OverrideDefault.Back.ColorAngle = 130F;
            btnEnrollFingerprint.OverrideDefault.Border.Color1 = Color.Red;
            btnEnrollFingerprint.OverrideDefault.Border.Color2 = Color.FromArgb(192, 0, 0);
            btnEnrollFingerprint.OverrideDefault.Border.ColorAngle = 130F;
            btnEnrollFingerprint.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEnrollFingerprint.OverrideDefault.Border.Rounding = 18F;
            btnEnrollFingerprint.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnEnrollFingerprint.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnEnrollFingerprint.OverrideDefault.Content.ShortText.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnrollFingerprint.Size = new Size(340, 42);
            btnEnrollFingerprint.StateCommon.Back.Color1 = Color.Red;
            btnEnrollFingerprint.StateCommon.Back.Color2 = Color.FromArgb(192, 0, 0);
            btnEnrollFingerprint.StateCommon.Back.ColorAngle = 45F;
            btnEnrollFingerprint.StateCommon.Border.Color1 = Color.Red;
            btnEnrollFingerprint.StateCommon.Border.Color2 = Color.Red;
            btnEnrollFingerprint.StateCommon.Border.ColorAngle = 130F;
            btnEnrollFingerprint.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEnrollFingerprint.StateCommon.Border.Rounding = 18F;
            btnEnrollFingerprint.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEnrollFingerprint.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEnrollFingerprint.StateCommon.Content.ShortText.Font = new Font("Archivo", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnrollFingerprint.StatePressed.Back.Color1 = Color.Red;
            btnEnrollFingerprint.StatePressed.Back.Color2 = Color.Red;
            btnEnrollFingerprint.StatePressed.Back.ColorAngle = 45F;
            btnEnrollFingerprint.StatePressed.Border.Color1 = Color.Red;
            btnEnrollFingerprint.StatePressed.Border.Color2 = Color.Red;
            btnEnrollFingerprint.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEnrollFingerprint.StatePressed.Border.Rounding = 18F;
            btnEnrollFingerprint.StatePressed.Content.ShortText.Color1 = Color.White;
            btnEnrollFingerprint.StatePressed.Content.ShortText.Color2 = Color.White;
            btnEnrollFingerprint.StatePressed.Content.ShortText.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnrollFingerprint.TabIndex = 49;
            btnEnrollFingerprint.Values.Text = "Enroll Fingerprint";
            btnEnrollFingerprint.Click += btnEnrollFingerprint_Click;
            // 
            // cbGender
            // 
            cbGender.DropDownWidth = 152;
            cbGender.IntegralHeight = false;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(315, 523);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(166, 36);
            cbGender.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbGender.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbGender.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbGender.StateCommon.ComboBox.Border.Rounding = 18F;
            cbGender.StateCommon.ComboBox.Border.Width = 2;
            cbGender.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbGender.StateCommon.ComboBox.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbGender.StateCommon.DropBack.Color1 = Color.White;
            cbGender.StateCommon.DropBack.Color2 = Color.White;
            cbGender.TabIndex = 48;
            // 
            // cbRoom
            // 
            cbRoom.DropDownWidth = 152;
            cbRoom.IntegralHeight = false;
            cbRoom.Items.AddRange(new object[] { "M201", "M203" });
            cbRoom.Location = new Point(141, 523);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(166, 36);
            cbRoom.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbRoom.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbRoom.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbRoom.StateCommon.ComboBox.Border.Rounding = 18F;
            cbRoom.StateCommon.ComboBox.Border.Width = 2;
            cbRoom.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbRoom.StateCommon.ComboBox.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoom.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbRoom.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbRoom.StateCommon.DropBack.Color1 = Color.White;
            cbRoom.StateCommon.DropBack.Color2 = Color.White;
            cbRoom.TabIndex = 47;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(315, 484);
            label8.Name = "label8";
            label8.Size = new Size(115, 36);
            label8.TabIndex = 46;
            label8.Text = "Gender *";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(141, 484);
            label7.Name = "label7";
            label7.Size = new Size(99, 36);
            label7.TabIndex = 44;
            label7.Text = "Room *";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(315, 314);
            label6.Name = "label6";
            label6.Size = new Size(117, 36);
            label6.TabIndex = 42;
            label6.Text = "Section *";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbSection
            // 
            cbSection.DropDownWidth = 152;
            cbSection.IntegralHeight = false;
            cbSection.Items.AddRange(new object[] { "Watt", "Faraday" });
            cbSection.Location = new Point(315, 356);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(166, 36);
            cbSection.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbSection.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbSection.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbSection.StateCommon.ComboBox.Border.Rounding = 18F;
            cbSection.StateCommon.ComboBox.Border.Width = 2;
            cbSection.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbSection.StateCommon.ComboBox.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbSection.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbSection.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbSection.StateCommon.DropBack.Color1 = Color.White;
            cbSection.StateCommon.DropBack.Color2 = Color.White;
            cbSection.TabIndex = 41;
            // 
            // tbStudentNum
            // 
            tbStudentNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbStudentNum.Location = new Point(141, 437);
            tbStudentNum.Name = "tbStudentNum";
            tbStudentNum.Size = new Size(340, 38);
            tbStudentNum.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbStudentNum.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbStudentNum.StateCommon.Border.ColorAngle = 45F;
            tbStudentNum.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbStudentNum.StateCommon.Border.Rounding = 18F;
            tbStudentNum.StateCommon.Border.Width = 2;
            tbStudentNum.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbStudentNum.TabIndex = 40;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(141, 403);
            label5.Name = "label5";
            label5.Size = new Size(215, 36);
            label5.TabIndex = 39;
            label5.Text = "Student Number *";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbMiddleInitial
            // 
            tbMiddleInitial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbMiddleInitial.Location = new Point(141, 356);
            tbMiddleInitial.Name = "tbMiddleInitial";
            tbMiddleInitial.Size = new Size(166, 38);
            tbMiddleInitial.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbMiddleInitial.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbMiddleInitial.StateCommon.Border.ColorAngle = 45F;
            tbMiddleInitial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbMiddleInitial.StateCommon.Border.Rounding = 18F;
            tbMiddleInitial.StateCommon.Border.Width = 2;
            tbMiddleInitial.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbMiddleInitial.TabIndex = 38;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(141, 315);
            label4.Name = "label4";
            label4.Size = new Size(158, 36);
            label4.TabIndex = 37;
            label4.Text = "Middle Initial";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbLastName.Location = new Point(141, 267);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(340, 38);
            tbLastName.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbLastName.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbLastName.StateCommon.Border.ColorAngle = 45F;
            tbLastName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbLastName.StateCommon.Border.Rounding = 18F;
            tbLastName.StateCommon.Border.Width = 2;
            tbLastName.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.TabIndex = 36;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(141, 233);
            label3.Name = "label3";
            label3.Size = new Size(151, 36);
            label3.TabIndex = 35;
            label3.Text = "Last Name *";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbFname
            // 
            tbFname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbFname.Location = new Point(141, 186);
            tbFname.Name = "tbFname";
            tbFname.Size = new Size(340, 38);
            tbFname.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbFname.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbFname.StateCommon.Border.ColorAngle = 45F;
            tbFname.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbFname.StateCommon.Border.Rounding = 18F;
            tbFname.StateCommon.Border.Width = 2;
            tbFname.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbFname.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(141, 152);
            label2.Name = "label2";
            label2.Size = new Size(153, 36);
            label2.TabIndex = 33;
            label2.Text = "First Name *";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Archivo", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(152, 56);
            label1.Name = "label1";
            label1.Size = new Size(311, 63);
            label1.TabIndex = 32;
            label1.Text = "Enroll Student";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.Humaaans___Study_Online;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 690);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // EnrollControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "EnrollControl";
            Size = new Size(1070, 690);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbSection).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Krypton.Toolkit.KryptonComboBox cbSection;
        private Krypton.Toolkit.KryptonTextBox tbStudentNum;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox tbMiddleInitial;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox tbLastName;
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox tbFname;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonComboBox cbGender;
        private Krypton.Toolkit.KryptonComboBox cbRoom;
        private Krypton.Toolkit.KryptonButton btnEnrollFingerprint;
    }
}
