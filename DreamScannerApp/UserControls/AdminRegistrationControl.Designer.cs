namespace DreamScannerApp.UserControls
{
    partial class AdminRegistrationControl
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
            btnEnrollFingerprint = new Krypton.Toolkit.KryptonButton();
            tbPassword = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            tbUserName = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            tbLastName = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            tbFname = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEnrollFingerprint
            // 
            btnEnrollFingerprint.Anchor = AnchorStyles.Top;
            btnEnrollFingerprint.Location = new Point(365, 593);
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
            btnEnrollFingerprint.TabIndex = 84;
            btnEnrollFingerprint.Values.Text = "Enroll Fingerprint";
            btnEnrollFingerprint.Click += btnEnrollFingerprint_Click;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbPassword.Location = new Point(365, 437);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '●';
            tbPassword.Size = new Size(340, 38);
            tbPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbPassword.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbPassword.StateCommon.Border.ColorAngle = 45F;
            tbPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbPassword.StateCommon.Border.Rounding = 18F;
            tbPassword.StateCommon.Border.Width = 2;
            tbPassword.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.TabIndex = 77;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(365, 403);
            label5.Name = "label5";
            label5.Size = new Size(144, 36);
            label5.TabIndex = 76;
            label5.Text = "Password *";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbUserName
            // 
            tbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbUserName.Location = new Point(365, 356);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(340, 38);
            tbUserName.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbUserName.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbUserName.StateCommon.Border.ColorAngle = 45F;
            tbUserName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbUserName.StateCommon.Border.Rounding = 18F;
            tbUserName.StateCommon.Border.Width = 2;
            tbUserName.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbUserName.TabIndex = 75;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(365, 315);
            label4.Name = "label4";
            label4.Size = new Size(152, 36);
            label4.TabIndex = 74;
            label4.Text = "User name *";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbLastName.Location = new Point(365, 267);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(340, 38);
            tbLastName.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbLastName.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbLastName.StateCommon.Border.ColorAngle = 45F;
            tbLastName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbLastName.StateCommon.Border.Rounding = 18F;
            tbLastName.StateCommon.Border.Width = 2;
            tbLastName.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.TabIndex = 73;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(365, 233);
            label3.Name = "label3";
            label3.Size = new Size(151, 36);
            label3.TabIndex = 72;
            label3.Text = "Last Name *";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbFname
            // 
            tbFname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbFname.Location = new Point(365, 186);
            tbFname.Name = "tbFname";
            tbFname.Size = new Size(340, 38);
            tbFname.StateCommon.Border.Color1 = Color.FromArgb(0, 0, 64);
            tbFname.StateCommon.Border.Color2 = Color.FromArgb(0, 0, 64);
            tbFname.StateCommon.Border.ColorAngle = 45F;
            tbFname.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbFname.StateCommon.Border.Rounding = 18F;
            tbFname.StateCommon.Border.Width = 2;
            tbFname.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbFname.TabIndex = 71;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Archivo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(365, 152);
            label2.Name = "label2";
            label2.Size = new Size(153, 36);
            label2.TabIndex = 70;
            label2.Text = "First Name *";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Archivo", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(376, 56);
            label1.Name = "label1";
            label1.Size = new Size(319, 63);
            label1.TabIndex = 69;
            label1.Text = "Admin Sign Up";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminRegistrationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnEnrollFingerprint);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(tbUserName);
            Controls.Add(label4);
            Controls.Add(tbLastName);
            Controls.Add(label3);
            Controls.Add(tbFname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminRegistrationControl";
            Size = new Size(1070, 690);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnEnrollFingerprint;
        private Krypton.Toolkit.KryptonTextBox tbPassword;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox tbUserName;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox tbLastName;
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox tbFname;
        private Label label2;
        private Label label1;
    }
}
