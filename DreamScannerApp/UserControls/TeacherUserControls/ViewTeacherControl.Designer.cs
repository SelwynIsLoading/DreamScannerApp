namespace DreamScannerApp.UserControls.TeacherUserControls
{
    partial class ViewTeacherControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgTeachers = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            TimeFrom = new DataGridViewTextBoxColumn();
            TimeTo = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Remove = new DataGridViewButtonColumn();
            btnNext = new Button();
            lblPage = new Label();
            btnPrevious = new Button();
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
            dgTeachers.Columns.AddRange(new DataGridViewColumn[] { Name, Subject, Room, TimeFrom, TimeTo, Gender, Edit, Remove });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgTeachers.DefaultCellStyle = dataGridViewCellStyle4;
            dgTeachers.EnableHeadersVisualStyles = false;
            dgTeachers.Location = new Point(0, 0);
            dgTeachers.Name = "dgTeachers";
            dgTeachers.ReadOnly = true;
            dgTeachers.RowHeadersVisible = false;
            dgTeachers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle5.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgTeachers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgTeachers.RowTemplate.Height = 29;
            dgTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTeachers.Size = new Size(1070, 442);
            dgTeachers.TabIndex = 1;
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
            // TimeFrom
            // 
            TimeFrom.HeaderText = "Time From";
            TimeFrom.MinimumWidth = 6;
            TimeFrom.Name = "TimeFrom";
            TimeFrom.ReadOnly = true;
            // 
            // TimeTo
            // 
            TimeTo.HeaderText = "Time To";
            TimeTo.MinimumWidth = 6;
            TimeTo.Name = "TimeTo";
            TimeTo.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.FillWeight = 50F;
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Edit";
            Edit.ToolTipText = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Remove
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            Remove.DefaultCellStyle = dataGridViewCellStyle3;
            Remove.FillWeight = 70F;
            Remove.HeaderText = "";
            Remove.MinimumWidth = 6;
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.Resizable = DataGridViewTriState.True;
            Remove.SortMode = DataGridViewColumnSortMode.Automatic;
            Remove.Text = "Remove";
            Remove.ToolTipText = "Remove";
            Remove.UseColumnTextForButtonValue = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(992, 444);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(64, 29);
            btnNext.TabIndex = 7;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPage.AutoSize = true;
            lblPage.Location = new Point(838, 448);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(25, 20);
            lblPage.TabIndex = 6;
            lblPage.Text = "10";
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(922, 443);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(64, 29);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // ViewTeacherControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Controls.Add(btnPrevious);
            Controls.Add(dgTeachers);
            Size = new Size(1070, 475);
            Load += ViewTeacherControl_Load;
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
        private DataGridViewTextBoxColumn TimeFrom;
        private DataGridViewTextBoxColumn TimeTo;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Remove;
    }
}
