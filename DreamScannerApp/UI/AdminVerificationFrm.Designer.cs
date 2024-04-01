namespace DreamScannerApp.UI
{
    partial class AdminVerificationFrm
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
            components = new System.ComponentModel.Container();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.OverrideFocus.Back.Color1 = Color.Transparent;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.OverrideFocus.Back.Color2 = Color.Transparent;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.OverrideFocus.Back.Color1 = Color.Transparent;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.OverrideFocus.Back.Color2 = Color.Transparent;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.OverrideFocus.Border.Color1 = Color.Transparent;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.OverrideFocus.Border.Color2 = Color.Transparent;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Border.Color1 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Border.Color2 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateActive.Border.Rounding = 18F;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.Color1 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.Color2 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCommon.StateCommon.Border.Rounding = 18F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.White;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.White;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.White;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fingerprint;
            pictureBox1.Location = new Point(31, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(95, 19);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 113;
            label1.Text = "Admin Verification";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(90, 349);
            label2.Name = "label2";
            label2.Size = new Size(260, 17);
            label2.TabIndex = 114;
            label2.Text = "Please place your finger on the scanner";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminVerificationFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 249);
            ClientSize = new Size(440, 387);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "AdminVerificationFrm";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Verification";
            FormClosed += AdminVerificationFrm_FormClosed;
            Load += AdminVerificationFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}