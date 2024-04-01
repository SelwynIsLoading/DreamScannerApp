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
            ((System.ComponentModel.ISupportInitialize)cbBreakTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbLunchTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbRecess).BeginInit();
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
            label4.Location = new Point(430, 168);
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
            cbBreakTime.Location = new Point(420, 200);
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
            label1.Location = new Point(430, 242);
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
            cbLunchTime.Location = new Point(420, 274);
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
            Recess.Location = new Point(430, 314);
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
            cbRecess.Location = new Point(420, 346);
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
            label2.Location = new Point(374, 31);
            label2.Name = "label2";
            label2.Size = new Size(322, 48);
            label2.TabIndex = 113;
            label2.Text = "Set Break Time";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // GeneralControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
    }
}
