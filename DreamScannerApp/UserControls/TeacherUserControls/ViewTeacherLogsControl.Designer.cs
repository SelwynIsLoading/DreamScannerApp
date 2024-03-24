namespace DreamScannerApp.UserControls.TeacherUserControls
{
    partial class ViewTeacherLogsControl
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.IndianRed;
            dataGridViewCellStyle11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgTeachers.ColumnHeadersHeight = 40;
            dgTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgTeachers.Columns.AddRange(new DataGridViewColumn[] { Name, Subject, Room, TimeFrom, TimeTo, Gender, Edit, Remove });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle14.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgTeachers.DefaultCellStyle = dataGridViewCellStyle14;
            dgTeachers.EnableHeadersVisualStyles = false;
            dgTeachers.Location = new Point(0, 0);
            dgTeachers.Name = "dgTeachers";
            dgTeachers.ReadOnly = true;
            dgTeachers.RowHeadersVisible = false;
            dgTeachers.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle15.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgTeachers.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgTeachers.RowTemplate.Height = 29;
            dgTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTeachers.Size = new Size(1070, 442);
            dgTeachers.TabIndex = 2;
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
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle12.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(64, 64, 64);
            Edit.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle13.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(64, 64, 64);
            Remove.DefaultCellStyle = dataGridViewCellStyle13;
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
            // ViewTeacherLogsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Controls.Add(btnPrevious);
            Controls.Add(dgTeachers);
            Name = "ViewTeacherLogsControl";
            Size = new Size(1070, 475);
            ((System.ComponentModel.ISupportInitialize)dgTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgTeachers;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn TimeFrom;
        private DataGridViewTextBoxColumn TimeTo;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Remove;
        private Button btnNext;
        private Label lblPage;
        private Button btnPrevious;
    }
}
