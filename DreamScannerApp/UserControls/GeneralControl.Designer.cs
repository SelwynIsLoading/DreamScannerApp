namespace DreamScannerApp.UserControls
{
    partial class GeneralControl
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
            btnSave = new Krypton.Toolkit.KryptonButton();
            label4 = new Label();
            cbBreakTime = new Krypton.Toolkit.KryptonComboBox();
            label1 = new Label();
            cbLunchTime = new Krypton.Toolkit.KryptonComboBox();
            Recess = new Label();
            cbRecess = new Krypton.Toolkit.KryptonComboBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            cbInvalidTries = new Krypton.Toolkit.KryptonComboBox();
            label7 = new Label();
            cbRoomPlaced = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)cbBreakTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbLunchTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbRecess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbInvalidTries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbRoomPlaced).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Location = new Point(365, 475);
            btnSave.Name = "btnSave";
            btnSave.OverrideDefault.Back.Color1 = Color.Red;
            btnSave.OverrideDefault.Back.Color2 = Color.FromArgb(192, 0, 0);
            btnSave.OverrideDefault.Back.ColorAngle = 130F;
            btnSave.OverrideDefault.Border.Color1 = Color.Red;
            btnSave.OverrideDefault.Border.Color2 = Color.FromArgb(192, 0, 0);
            btnSave.OverrideDefault.Border.ColorAngle = 130F;
            btnSave.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.OverrideDefault.Border.Rounding = 18F;
            btnSave.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnSave.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnSave.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Size = new Size(341, 43);
            btnSave.StateCommon.Back.Color1 = Color.Red;
            btnSave.StateCommon.Back.Color2 = Color.FromArgb(192, 0, 0);
            btnSave.StateCommon.Back.ColorAngle = 45F;
            btnSave.StateCommon.Border.Color1 = Color.Red;
            btnSave.StateCommon.Border.Color2 = Color.Red;
            btnSave.StateCommon.Border.ColorAngle = 130F;
            btnSave.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.StateCommon.Border.Rounding = 18F;
            btnSave.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSave.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSave.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.StatePressed.Back.Color1 = Color.Red;
            btnSave.StatePressed.Back.Color2 = Color.Red;
            btnSave.StatePressed.Back.ColorAngle = 45F;
            btnSave.StatePressed.Border.Color1 = Color.Red;
            btnSave.StatePressed.Border.Color2 = Color.Red;
            btnSave.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.StatePressed.Border.Rounding = 18F;
            btnSave.StatePressed.Content.ShortText.Color1 = Color.White;
            btnSave.StatePressed.Content.ShortText.Color2 = Color.White;
            btnSave.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.TabIndex = 67;
            btnSave.Values.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(233, 168);
            label4.Name = "label4";
            label4.Size = new Size(166, 29);
            label4.TabIndex = 68;
            label4.Text = "Minute Break";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbBreakTime
            // 
            cbBreakTime.Anchor = AnchorStyles.Top;
            cbBreakTime.DropDownWidth = 152;
            cbBreakTime.IntegralHeight = false;
            cbBreakTime.Location = new Point(223, 200);
            cbBreakTime.Name = "cbBreakTime";
            cbBreakTime.Size = new Size(230, 36);
            cbBreakTime.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbBreakTime.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbBreakTime.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbBreakTime.StateCommon.ComboBox.Border.Rounding = 18F;
            cbBreakTime.StateCommon.ComboBox.Border.Width = 2;
            cbBreakTime.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbBreakTime.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbBreakTime.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbBreakTime.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbBreakTime.StateCommon.DropBack.Color1 = Color.White;
            cbBreakTime.StateCommon.DropBack.Color2 = Color.White;
            cbBreakTime.TabIndex = 66;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(233, 242);
            label1.Name = "label1";
            label1.Size = new Size(157, 29);
            label1.TabIndex = 70;
            label1.Text = "Lunch Break";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbLunchTime
            // 
            cbLunchTime.Anchor = AnchorStyles.Top;
            cbLunchTime.DropDownWidth = 152;
            cbLunchTime.IntegralHeight = false;
            cbLunchTime.Location = new Point(223, 274);
            cbLunchTime.Name = "cbLunchTime";
            cbLunchTime.Size = new Size(230, 36);
            cbLunchTime.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbLunchTime.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbLunchTime.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbLunchTime.StateCommon.ComboBox.Border.Rounding = 18F;
            cbLunchTime.StateCommon.ComboBox.Border.Width = 2;
            cbLunchTime.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbLunchTime.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbLunchTime.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbLunchTime.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbLunchTime.StateCommon.DropBack.Color1 = Color.White;
            cbLunchTime.StateCommon.DropBack.Color2 = Color.White;
            cbLunchTime.TabIndex = 69;
            // 
            // Recess
            // 
            Recess.Anchor = AnchorStyles.Top;
            Recess.AutoSize = true;
            Recess.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Recess.ForeColor = Color.FromArgb(0, 0, 64);
            Recess.Location = new Point(233, 314);
            Recess.Name = "Recess";
            Recess.Size = new Size(100, 29);
            Recess.TabIndex = 72;
            Recess.Text = "Recess";
            Recess.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbRecess
            // 
            cbRecess.Anchor = AnchorStyles.Top;
            cbRecess.DropDownWidth = 152;
            cbRecess.IntegralHeight = false;
            cbRecess.Location = new Point(223, 346);
            cbRecess.Name = "cbRecess";
            cbRecess.Size = new Size(230, 36);
            cbRecess.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbRecess.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbRecess.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbRecess.StateCommon.ComboBox.Border.Rounding = 18F;
            cbRecess.StateCommon.ComboBox.Border.Width = 2;
            cbRecess.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbRecess.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbRecess.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbRecess.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbRecess.StateCommon.DropBack.Color1 = Color.White;
            cbRecess.StateCommon.DropBack.Color2 = Color.White;
            cbRecess.TabIndex = 71;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(177, 31);
            label2.Name = "label2";
            label2.Size = new Size(322, 48);
            label2.TabIndex = 113;
            label2.Text = "Set Break Time";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(632, 31);
            label3.Name = "label3";
            label3.Size = new Size(194, 48);
            label3.TabIndex = 119;
            label3.Text = "Intruders";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(632, 242);
            label6.Name = "label6";
            label6.Size = new Size(157, 29);
            label6.TabIndex = 117;
            label6.Text = "Invalid Tries";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbInvalidTries
            // 
            cbInvalidTries.Anchor = AnchorStyles.Top;
            cbInvalidTries.DropDownWidth = 152;
            cbInvalidTries.IntegralHeight = false;
            cbInvalidTries.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbInvalidTries.Location = new Point(622, 274);
            cbInvalidTries.Name = "cbInvalidTries";
            cbInvalidTries.Size = new Size(230, 36);
            cbInvalidTries.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbInvalidTries.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbInvalidTries.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbInvalidTries.StateCommon.ComboBox.Border.Rounding = 18F;
            cbInvalidTries.StateCommon.ComboBox.Border.Width = 2;
            cbInvalidTries.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbInvalidTries.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbInvalidTries.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbInvalidTries.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbInvalidTries.StateCommon.DropBack.Color1 = Color.White;
            cbInvalidTries.StateCommon.DropBack.Color2 = Color.White;
            cbInvalidTries.TabIndex = 116;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(632, 168);
            label7.Name = "label7";
            label7.Size = new Size(170, 29);
            label7.TabIndex = 115;
            label7.Text = "Room Placed";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbRoomPlaced
            // 
            cbRoomPlaced.Anchor = AnchorStyles.Top;
            cbRoomPlaced.DropDownWidth = 152;
            cbRoomPlaced.IntegralHeight = false;
            cbRoomPlaced.Items.AddRange(new object[] { "M201", "M203" });
            cbRoomPlaced.Location = new Point(622, 200);
            cbRoomPlaced.Name = "cbRoomPlaced";
            cbRoomPlaced.Size = new Size(230, 36);
            cbRoomPlaced.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbRoomPlaced.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbRoomPlaced.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbRoomPlaced.StateCommon.ComboBox.Border.Rounding = 18F;
            cbRoomPlaced.StateCommon.ComboBox.Border.Width = 2;
            cbRoomPlaced.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbRoomPlaced.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoomPlaced.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbRoomPlaced.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbRoomPlaced.StateCommon.DropBack.Color1 = Color.White;
            cbRoomPlaced.StateCommon.DropBack.Color2 = Color.White;
            cbRoomPlaced.TabIndex = 114;
            // 
            // GeneralControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(cbInvalidTries);
            Controls.Add(label7);
            Controls.Add(cbRoomPlaced);
            Controls.Add(label2);
            Controls.Add(Recess);
            Controls.Add(cbRecess);
            Controls.Add(label1);
            Controls.Add(cbLunchTime);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(cbBreakTime);
            Name = "GeneralControl";
            Size = new Size(1070, 551);
            Load += GeneralControl_Load;
            ((System.ComponentModel.ISupportInitialize)cbBreakTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbLunchTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbRecess).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbInvalidTries).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbRoomPlaced).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnSave;
        private Label label4;
        private Krypton.Toolkit.KryptonComboBox cbBreakTime;
        private Label label1;
        private Krypton.Toolkit.KryptonComboBox cbLunchTime;
        private Label Recess;
        private Krypton.Toolkit.KryptonComboBox cbRecess;
        private Label label2;
        private Label label3;
        private Label label6;
        private Krypton.Toolkit.KryptonComboBox cbInvalidTries;
        private Label label7;
        private Krypton.Toolkit.KryptonComboBox cbRoomPlaced;
    }
}
