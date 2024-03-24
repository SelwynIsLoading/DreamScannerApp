namespace DreamScannerApp.UserControls
{
    partial class VerifyControl
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
            tbState = new TextBox();
            tbStatus = new TextBox();
            tbInOut = new TextBox();
            tbSection = new TextBox();
            tbName = new TextBox();
            pbGender = new PictureBox();
            label1 = new Label();
            chkHold = new Krypton.Toolkit.KryptonCheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGender).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(chkHold);
            panel1.Controls.Add(tbState);
            panel1.Controls.Add(tbStatus);
            panel1.Controls.Add(tbInOut);
            panel1.Controls.Add(tbSection);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(pbGender);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(119, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 690);
            panel1.TabIndex = 0;
            // 
            // tbState
            // 
            tbState.Anchor = AnchorStyles.Bottom;
            tbState.BackColor = Color.White;
            tbState.BorderStyle = BorderStyle.None;
            tbState.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbState.Location = new Point(159, 521);
            tbState.Multiline = true;
            tbState.Name = "tbState";
            tbState.ReadOnly = true;
            tbState.Size = new Size(514, 34);
            tbState.TabIndex = 7;
            tbState.Text = "Status";
            tbState.TextAlign = HorizontalAlignment.Center;
            // 
            // tbStatus
            // 
            tbStatus.Anchor = AnchorStyles.Bottom;
            tbStatus.BackColor = Color.White;
            tbStatus.BorderStyle = BorderStyle.None;
            tbStatus.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbStatus.Location = new Point(159, 571);
            tbStatus.Multiline = true;
            tbStatus.Name = "tbStatus";
            tbStatus.ReadOnly = true;
            tbStatus.Size = new Size(514, 64);
            tbStatus.TabIndex = 6;
            tbStatus.Text = "Status";
            tbStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // tbInOut
            // 
            tbInOut.Anchor = AnchorStyles.Bottom;
            tbInOut.BackColor = Color.White;
            tbInOut.BorderStyle = BorderStyle.None;
            tbInOut.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbInOut.Location = new Point(159, 465);
            tbInOut.Name = "tbInOut";
            tbInOut.ReadOnly = true;
            tbInOut.Size = new Size(514, 38);
            tbInOut.TabIndex = 5;
            tbInOut.Text = "Out";
            tbInOut.TextAlign = HorizontalAlignment.Center;
            // 
            // tbSection
            // 
            tbSection.Anchor = AnchorStyles.Bottom;
            tbSection.BackColor = Color.White;
            tbSection.BorderStyle = BorderStyle.None;
            tbSection.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbSection.Location = new Point(159, 371);
            tbSection.Name = "tbSection";
            tbSection.ReadOnly = true;
            tbSection.Size = new Size(514, 32);
            tbSection.TabIndex = 4;
            tbSection.Text = "section";
            tbSection.TextAlign = HorizontalAlignment.Center;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Bottom;
            tbName.BackColor = Color.White;
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbName.Location = new Point(159, 328);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(514, 38);
            tbName.TabIndex = 3;
            tbName.Text = "Name";
            tbName.TextAlign = HorizontalAlignment.Center;
            // 
            // pbGender
            // 
            pbGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pbGender.Image = Properties.Resources.Invalid;
            pbGender.Location = new Point(310, 106);
            pbGender.Name = "pbGender";
            pbGender.Size = new Size(213, 180);
            pbGender.SizeMode = PictureBoxSizeMode.Zoom;
            pbGender.TabIndex = 2;
            pbGender.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Archivo", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(345, 27);
            label1.Name = "label1";
            label1.Size = new Size(143, 63);
            label1.TabIndex = 1;
            label1.Text = "Verify";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // chkHold
            // 
            chkHold.Location = new Point(366, 653);
            chkHold.Name = "chkHold";
            chkHold.Size = new Size(106, 22);
            chkHold.StateCommon.ShortText.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkHold.TabIndex = 9;
            chkHold.Values.Text = "Hold Logging";
            // 
            // VerifyControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "VerifyControl";
            Size = new Size(1070, 690);
            Load += VerifyControl_Load;
            VisibleChanged += VerifyControl_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGender).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pbGender;
        private TextBox tbInOut;
        private TextBox tbSection;
        private TextBox tbName;
        private TextBox tbStatus;
        private TextBox tbState;
        private Krypton.Toolkit.KryptonCheckBox chkHold;
    }
}
