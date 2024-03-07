namespace DreamScannerApp.UserControls
{
    partial class FingerprintAddControl
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
            tbStatus = new TextBox();
            pbFingerprint = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFingerprint).BeginInit();
            SuspendLayout();
            // 
            // tbStatus
            // 
            tbStatus.BackColor = Color.White;
            tbStatus.Font = new Font("Archivo", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            tbStatus.Location = new Point(38, 413);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(427, 26);
            tbStatus.TabIndex = 10;
            tbStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // pbFingerprint
            // 
            pbFingerprint.Location = new Point(64, 71);
            pbFingerprint.Name = "pbFingerprint";
            pbFingerprint.Size = new Size(375, 320);
            pbFingerprint.SizeMode = PictureBoxSizeMode.Zoom;
            pbFingerprint.TabIndex = 9;
            pbFingerprint.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Archivo", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(86, 10);
            label1.Name = "label1";
            label1.Size = new Size(303, 41);
            label1.TabIndex = 8;
            label1.Text = "Fingerprint Enrollment";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FingerprintAddControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbStatus);
            Controls.Add(pbFingerprint);
            Controls.Add(label1);
            Name = "FingerprintAddControl";
            Size = new Size(502, 477);
            Load += FingerprintAddControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbFingerprint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbStatus;
        private PictureBox pbFingerprint;
        private Label label1;
    }
}
