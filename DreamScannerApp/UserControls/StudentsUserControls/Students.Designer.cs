namespace DreamScannerApp.UserControls.StudentsUserControls
{
    partial class Students
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
            dPicker = new Krypton.Toolkit.KryptonDateTimePicker();
            cbFilter = new Krypton.Toolkit.KryptonComboBox();
            btnViewLogs = new Krypton.Toolkit.KryptonButton();
            btnSearch = new Krypton.Toolkit.KryptonButton();
            tbSearch = new Krypton.Toolkit.KryptonTextBox();
            pnlContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbFilter).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dPicker);
            panel1.Controls.Add(cbFilter);
            panel1.Controls.Add(btnViewLogs);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 76);
            panel1.TabIndex = 1;
            // 
            // dPicker
            // 
            dPicker.CausesValidation = false;
            dPicker.Format = DateTimePickerFormat.Short;
            dPicker.Location = new Point(558, 16);
            dPicker.Name = "dPicker";
            dPicker.Size = new Size(160, 35);
            dPicker.StateCommon.Border.Color1 = Color.Red;
            dPicker.StateCommon.Border.Color2 = Color.Red;
            dPicker.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dPicker.StateCommon.Border.Rounding = 15F;
            dPicker.StateCommon.Border.Width = 2;
            dPicker.StateCommon.Content.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dPicker.TabIndex = 55;
            dPicker.ValueChanged += dPicker_ValueChanged;
            // 
            // cbFilter
            // 
            cbFilter.DropDownWidth = 152;
            cbFilter.IntegralHeight = false;
            cbFilter.Location = new Point(352, 18);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(166, 34);
            cbFilter.StateCommon.ComboBox.Border.Color1 = Color.Red;
            cbFilter.StateCommon.ComboBox.Border.Color2 = Color.Red;
            cbFilter.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbFilter.StateCommon.ComboBox.Border.Rounding = 18F;
            cbFilter.StateCommon.ComboBox.Border.Width = 2;
            cbFilter.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbFilter.StateCommon.ComboBox.Content.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbFilter.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbFilter.StateCommon.DropBack.Color1 = Color.White;
            cbFilter.StateCommon.DropBack.Color2 = Color.White;
            cbFilter.TabIndex = 54;
            cbFilter.SelectedValueChanged += cbFilter_SelectedValueChanged;
            // 
            // btnViewLogs
            // 
            btnViewLogs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewLogs.Location = new Point(883, 16);
            btnViewLogs.Name = "btnViewLogs";
            btnViewLogs.OverrideDefault.Back.Color1 = Color.White;
            btnViewLogs.OverrideDefault.Back.Color2 = Color.White;
            btnViewLogs.OverrideDefault.Back.ColorAngle = 130F;
            btnViewLogs.OverrideDefault.Border.Color1 = Color.Red;
            btnViewLogs.OverrideDefault.Border.Color2 = Color.FromArgb(192, 0, 0);
            btnViewLogs.OverrideDefault.Border.ColorAngle = 130F;
            btnViewLogs.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnViewLogs.OverrideDefault.Border.Rounding = 18F;
            btnViewLogs.OverrideDefault.Content.ShortText.Color1 = Color.Red;
            btnViewLogs.OverrideDefault.Content.ShortText.Color2 = Color.Red;
            btnViewLogs.OverrideDefault.Content.ShortText.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewLogs.Size = new Size(164, 38);
            btnViewLogs.StateCommon.Back.Color1 = Color.White;
            btnViewLogs.StateCommon.Back.Color2 = Color.White;
            btnViewLogs.StateCommon.Back.ColorAngle = 45F;
            btnViewLogs.StateCommon.Border.Color1 = Color.Red;
            btnViewLogs.StateCommon.Border.Color2 = Color.Red;
            btnViewLogs.StateCommon.Border.ColorAngle = 130F;
            btnViewLogs.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnViewLogs.StateCommon.Border.Rounding = 18F;
            btnViewLogs.StateCommon.Border.Width = 2;
            btnViewLogs.StateCommon.Content.ShortText.Color1 = Color.Red;
            btnViewLogs.StateCommon.Content.ShortText.Color2 = Color.Red;
            btnViewLogs.StateCommon.Content.ShortText.Font = new Font("Archivo", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewLogs.StatePressed.Back.Color1 = Color.White;
            btnViewLogs.StatePressed.Back.Color2 = Color.White;
            btnViewLogs.StatePressed.Back.ColorAngle = 45F;
            btnViewLogs.StatePressed.Border.Color1 = Color.Red;
            btnViewLogs.StatePressed.Border.Color2 = Color.Red;
            btnViewLogs.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnViewLogs.StatePressed.Border.Rounding = 18F;
            btnViewLogs.StatePressed.Content.ShortText.Color1 = Color.Red;
            btnViewLogs.StatePressed.Content.ShortText.Color2 = Color.Red;
            btnViewLogs.StatePressed.Content.ShortText.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewLogs.StateTracking.Back.Color1 = Color.Red;
            btnViewLogs.StateTracking.Back.Color2 = Color.FromArgb(192, 0, 0);
            btnViewLogs.StateTracking.Back.ColorAngle = 130F;
            btnViewLogs.StateTracking.Border.Color1 = Color.Red;
            btnViewLogs.StateTracking.Border.Color2 = Color.FromArgb(192, 0, 0);
            btnViewLogs.StateTracking.Border.ColorAngle = 45F;
            btnViewLogs.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnViewLogs.StateTracking.Border.Rounding = 18F;
            btnViewLogs.StateTracking.Content.ShortText.Color1 = Color.White;
            btnViewLogs.StateTracking.Content.ShortText.Color2 = Color.White;
            btnViewLogs.StateTracking.Content.ShortText.Font = new Font("Archivo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewLogs.TabIndex = 53;
            btnViewLogs.Values.Text = "View Student Logs";
            btnViewLogs.Click += btnViewLogs_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(211, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.OverrideDefault.Back.Color1 = Color.White;
            btnSearch.OverrideDefault.Back.Color2 = Color.White;
            btnSearch.OverrideDefault.Back.Image = Properties.Resources.icons8_search_25;
            btnSearch.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnSearch.OverrideDefault.Border.Color1 = Color.FromArgb(250, 82, 82);
            btnSearch.OverrideDefault.Border.Color2 = Color.FromArgb(250, 82, 82);
            btnSearch.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.OverrideDefault.Border.Rounding = 35F;
            btnSearch.OverrideDefault.Border.Width = 2;
            btnSearch.Size = new Size(38, 38);
            btnSearch.StateCommon.Back.Color1 = Color.White;
            btnSearch.StateCommon.Back.Color2 = Color.White;
            btnSearch.StateCommon.Back.Image = Properties.Resources.icons8_search_25;
            btnSearch.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnSearch.StateCommon.Border.Color1 = Color.FromArgb(250, 82, 82);
            btnSearch.StateCommon.Border.Color2 = Color.FromArgb(250, 82, 82);
            btnSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StateCommon.Border.Rounding = 35F;
            btnSearch.StateCommon.Border.Width = 2;
            btnSearch.StatePressed.Back.Color1 = Color.White;
            btnSearch.StatePressed.Back.Color2 = Color.White;
            btnSearch.StatePressed.Back.Image = Properties.Resources.icons8_search_25;
            btnSearch.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnSearch.StatePressed.Border.Color1 = Color.FromArgb(250, 82, 82);
            btnSearch.StatePressed.Border.Color2 = Color.FromArgb(250, 82, 82);
            btnSearch.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StatePressed.Border.Rounding = 35F;
            btnSearch.StatePressed.Border.Width = 2;
            btnSearch.TabIndex = 40;
            btnSearch.Values.Text = "";
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(39, 16);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(166, 38);
            tbSearch.StateCommon.Border.Color1 = Color.FromArgb(250, 82, 82);
            tbSearch.StateCommon.Border.Color2 = Color.FromArgb(250, 82, 82);
            tbSearch.StateCommon.Border.ColorAngle = 45F;
            tbSearch.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            tbSearch.StateCommon.Border.Rounding = 18F;
            tbSearch.StateCommon.Border.Width = 2;
            tbSearch.StateCommon.Content.Font = new Font("Archivo", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.TabIndex = 39;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 76);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1070, 475);
            pnlContainer.TabIndex = 2;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            Name = "Students";
            Size = new Size(1070, 551);
            Load += Students_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbFilter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox tbSearch;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonButton btnViewLogs;
        private Panel pnlContainer;
        private Krypton.Toolkit.KryptonDateTimePicker dPicker;
        private Krypton.Toolkit.KryptonComboBox cbFilter;
    }
}
