namespace DreamScannerApp.UserControls.TeacherUserControls
{
    partial class ViewTeacherLogControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgTeachers = new DataGridView();
            btnNext = new Button();
            lblPage = new Label();
            btnPrevious = new Button();
            Name = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            Attendance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgTeachers).BeginInit();
            SuspendLayout();
            // 
            // dgTeachers
            // 
            dgTeachers.AllowUserToAddRows = false;
            dgTeachers.AllowUserToDeleteRows = false;
            dgTeachers.AllowUserToResizeRows = false;
            dgTeachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTeachers.BackgroundColor = Color.White;
            dgTeachers.BorderStyle = BorderStyle.None;
            dgTeachers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgTeachers.ColumnHeadersHeight = 40;
            dgTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgTeachers.Columns.AddRange(new DataGridViewColumn[] { Name, Subject, Room, Section, TimeIn, TimeOut, Attendance });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgTeachers.DefaultCellStyle = dataGridViewCellStyle2;
            dgTeachers.EnableHeadersVisualStyles = false;
            dgTeachers.Location = new Point(0, 0);
            dgTeachers.Name = "dgTeachers";
            dgTeachers.ReadOnly = true;
            dgTeachers.RowHeadersVisible = false;
            dgTeachers.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgTeachers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgTeachers.RowTemplate.Height = 29;
            dgTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTeachers.Size = new Size(1070, 442);
            dgTeachers.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(987, 443);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(64, 29);
            btnNext.TabIndex = 10;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPage.AutoSize = true;
            lblPage.Location = new Point(833, 447);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(25, 20);
            lblPage.TabIndex = 9;
            lblPage.Text = "10";
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(917, 442);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(64, 29);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            Name.FillWeight = 150F;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Subject
            // 
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            // 
            // Room
            // 
            Room.HeaderText = "Room";
            Room.MinimumWidth = 6;
            Room.Name = "Room";
            Room.ReadOnly = true;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.MinimumWidth = 6;
            Section.Name = "Section";
            Section.ReadOnly = true;
            // 
            // TimeIn
            // 
            TimeIn.HeaderText = "Time In";
            TimeIn.MinimumWidth = 6;
            TimeIn.Name = "TimeIn";
            TimeIn.ReadOnly = true;
            // 
            // TimeOut
            // 
            TimeOut.HeaderText = "Time Out";
            TimeOut.MinimumWidth = 6;
            TimeOut.Name = "TimeOut";
            TimeOut.ReadOnly = true;
            // 
            // Attendance
            // 
            Attendance.HeaderText = "Attendance";
            Attendance.MinimumWidth = 6;
            Attendance.Name = "Attendance";
            Attendance.ReadOnly = true;
            // 
            // ViewTeacherLogControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Controls.Add(btnPrevious);
            Controls.Add(dgTeachers);
            Size = new Size(1070, 475);
            Load += ViewTeacherLogsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgTeachers;
        private Button btnNext;
        private Label lblPage;
        private Button btnPrevious;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewTextBoxColumn Attendance;
    }
}
