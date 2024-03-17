namespace DreamScannerApp.UserControls.StudentsUserControls
{
    partial class ViewStudentLogsControl
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
            dgStudents = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            StudentNumber = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            Attendance = new DataGridViewTextBoxColumn();
            vScrollBar = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)dgStudents).BeginInit();
            SuspendLayout();
            // 
            // dgStudents
            // 
            dgStudents.AllowUserToAddRows = false;
            dgStudents.AllowUserToDeleteRows = false;
            dgStudents.AllowUserToResizeRows = false;
            dgStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStudents.BackgroundColor = Color.White;
            dgStudents.BorderStyle = BorderStyle.None;
            dgStudents.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgStudents.ColumnHeadersHeight = 40;
            dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgStudents.Columns.AddRange(new DataGridViewColumn[] { Name, StudentNumber, Section, Room, Date, TimeIn, TimeOut, Attendance });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgStudents.EnableHeadersVisualStyles = false;
            dgStudents.Location = new Point(0, 0);
            dgStudents.Name = "dgStudents";
            dgStudents.ReadOnly = true;
            dgStudents.RowHeadersVisible = false;
            dgStudents.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgStudents.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgStudents.RowTemplate.Height = 29;
            dgStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudents.Size = new Size(1047, 475);
            dgStudents.TabIndex = 1;
            // 
            // Name
            // 
            Name.FillWeight = 150F;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // StudentNumber
            // 
            StudentNumber.FillWeight = 150F;
            StudentNumber.HeaderText = "Student Number";
            StudentNumber.MinimumWidth = 6;
            StudentNumber.Name = "StudentNumber";
            StudentNumber.ReadOnly = true;
            // 
            // Section
            // 
            Section.HeaderText = "Section";
            Section.MinimumWidth = 6;
            Section.Name = "Section";
            Section.ReadOnly = true;
            // 
            // Room
            // 
            Room.HeaderText = "Room";
            Room.MinimumWidth = 6;
            Room.Name = "Room";
            Room.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
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
            // vScrollBar
            // 
            vScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            vScrollBar.Location = new Point(1050, 38);
            vScrollBar.Name = "vScrollBar";
            vScrollBar.Size = new Size(20, 437);
            vScrollBar.TabIndex = 2;
            // 
            // ViewStudentLogsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(vScrollBar);
            Controls.Add(dgStudents);
            Size = new Size(1070, 475);
            Load += ViewStudentLogsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgStudents;
        private VScrollBar vScrollBar;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn StudentNumber;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewTextBoxColumn Attendance;
    }
}
