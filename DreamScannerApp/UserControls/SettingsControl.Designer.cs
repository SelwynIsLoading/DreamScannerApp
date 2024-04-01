namespace DreamScannerApp.UserControls
{
    partial class SettingsControl
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
            label1 = new Label();
            panel2 = new Panel();
            btnController = new Button();
            btnReports = new Button();
            btnTeachers = new Button();
            btnStudents = new Button();
            btnActive = new Panel();
            containerPnl = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 82, 82);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Archivo", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 63);
            label1.TabIndex = 33;
            label1.Text = "Settings";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnController);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnTeachers);
            panel2.Controls.Add(btnStudents);
            panel2.Controls.Add(btnActive);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 71);
            panel2.TabIndex = 1;
            // 
            // btnController
            // 
            btnController.BackColor = SystemColors.Control;
            btnController.FlatAppearance.BorderSize = 0;
            btnController.FlatStyle = FlatStyle.Flat;
            btnController.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnController.ForeColor = Color.FromArgb(250, 82, 82);
            btnController.Location = new Point(536, 0);
            btnController.Name = "btnController";
            btnController.Size = new Size(166, 59);
            btnController.TabIndex = 8;
            btnController.Text = "Controller";
            btnController.UseVisualStyleBackColor = false;
            btnController.Click += btnController_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.Control;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = Color.FromArgb(250, 82, 82);
            btnReports.Location = new Point(364, 0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(166, 59);
            btnReports.TabIndex = 7;
            btnReports.Text = "General";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = SystemColors.Control;
            btnTeachers.FlatAppearance.BorderSize = 0;
            btnTeachers.FlatStyle = FlatStyle.Flat;
            btnTeachers.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeachers.ForeColor = Color.FromArgb(250, 82, 82);
            btnTeachers.Location = new Point(192, 0);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(166, 59);
            btnTeachers.TabIndex = 6;
            btnTeachers.Text = "Teachers";
            btnTeachers.UseVisualStyleBackColor = false;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = SystemColors.Control;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudents.ForeColor = Color.FromArgb(250, 82, 82);
            btnStudents.Location = new Point(20, 0);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(166, 59);
            btnStudents.TabIndex = 5;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnActive
            // 
            btnActive.BackColor = Color.FromArgb(250, 82, 82);
            btnActive.Location = new Point(20, 61);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(167, 10);
            btnActive.TabIndex = 3;
            // 
            // containerPnl
            // 
            containerPnl.BackColor = Color.White;
            containerPnl.Dock = DockStyle.Fill;
            containerPnl.Location = new Point(0, 139);
            containerPnl.Name = "containerPnl";
            containerPnl.Size = new Size(1070, 551);
            containerPnl.TabIndex = 2;
            containerPnl.Paint += containerPnl_Paint;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(containerPnl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SettingsControl";
            Size = new Size(1070, 690);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel btnActive;
        private Button btnStudents;
        private Button btnController;
        private Button btnReports;
        private Button btnTeachers;
        private Panel containerPnl;
    }
}
