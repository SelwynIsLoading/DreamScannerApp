namespace DreamScannerApp.UserControls.StudentsUserControls
{
    partial class ViewStudentsControl
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
            dgStudents = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleInitial = new DataGridViewTextBoxColumn();
            StudentNumber = new DataGridViewTextBoxColumn();
            Section = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Remove = new DataGridViewButtonColumn();
            btnPrevious = new Button();
            lblPage = new Label();
            btnNext = new Button();
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
            dgStudents.Columns.AddRange(new DataGridViewColumn[] { LastName, FirstName, MiddleInitial, StudentNumber, Section, Room, Gender, Edit, Remove });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgStudents.DefaultCellStyle = dataGridViewCellStyle4;
            dgStudents.EnableHeadersVisualStyles = false;
            dgStudents.Location = new Point(0, 0);
            dgStudents.Name = "dgStudents";
            dgStudents.ReadOnly = true;
            dgStudents.RowHeadersVisible = false;
            dgStudents.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle5.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgStudents.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgStudents.RowTemplate.Height = 29;
            dgStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudents.Size = new Size(1070, 442);
            dgStudents.TabIndex = 0;
            dgStudents.CellClick += dgStudents_CellClick;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // MiddleInitial
            // 
            MiddleInitial.HeaderText = "Middle Name";
            MiddleInitial.MinimumWidth = 6;
            MiddleInitial.Name = "MiddleInitial";
            MiddleInitial.ReadOnly = true;
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
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(908, 443);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(64, 29);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPage.AutoSize = true;
            lblPage.Location = new Point(824, 448);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(25, 20);
            lblPage.TabIndex = 3;
            lblPage.Text = "10";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(978, 444);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(64, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ViewStudentsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(lblPage);
            Controls.Add(btnPrevious);
            Controls.Add(dgStudents);
            Name = "ViewStudentsControl";
            Size = new Size(1070, 475);
            Load += ViewStudentsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgStudents;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleInitial;
        private DataGridViewTextBoxColumn StudentNumber;
        private DataGridViewTextBoxColumn Section;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Remove;
        private Button btnPrevious;
        private Label lblPage;
        private Button btnNext;
    }
}
