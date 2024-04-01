namespace DreamScannerApp.UserControls
{
    partial class ControllerControl
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
            label2 = new Label();
            label4 = new Label();
            btnSave = new Krypton.Toolkit.KryptonButton();
            cbPorts = new Krypton.Toolkit.KryptonComboBox();
            label1 = new Label();
            cbBaudRate = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)cbPorts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbBaudRate).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(450, 32);
            label2.Name = "label2";
            label2.Size = new Size(171, 48);
            label2.TabIndex = 121;
            label2.Text = "Arduino";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(430, 169);
            label4.Name = "label4";
            label4.Size = new Size(137, 29);
            label4.TabIndex = 116;
            label4.Text = "Port Name";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Location = new Point(365, 476);
            btnSave.Name = "btnSave";
            btnSave.OverrideDefault.Back.Color1 = Color.Red;
            btnSave.OverrideDefault.Back.Color2 = Color.FromArgb(192, 0, 0);
            btnSave.OverrideDefault.Back.ColorAngle = 130F;
            btnSave.OverrideDefault.Border.Color1 = Color.Red;
            btnSave.OverrideDefault.Border.Color2 = Color.FromArgb(192, 0, 0);
            btnSave.OverrideDefault.Border.ColorAngle = 130F;
            btnSave.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.OverrideDefault.Border.Rounding = 18F;
            btnSave.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnSave.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnSave.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Size = new Size(341, 43);
            btnSave.StateCommon.Back.Color1 = Color.Red;
            btnSave.StateCommon.Back.Color2 = Color.FromArgb(192, 0, 0);
            btnSave.StateCommon.Back.ColorAngle = 45F;
            btnSave.StateCommon.Border.Color1 = Color.Red;
            btnSave.StateCommon.Border.Color2 = Color.Red;
            btnSave.StateCommon.Border.ColorAngle = 130F;
            btnSave.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.StateCommon.Border.Rounding = 18F;
            btnSave.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSave.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSave.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.StatePressed.Back.Color1 = Color.Red;
            btnSave.StatePressed.Back.Color2 = Color.Red;
            btnSave.StatePressed.Back.ColorAngle = 45F;
            btnSave.StatePressed.Border.Color1 = Color.Red;
            btnSave.StatePressed.Border.Color2 = Color.Red;
            btnSave.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSave.StatePressed.Border.Rounding = 18F;
            btnSave.StatePressed.Content.ShortText.Color1 = Color.White;
            btnSave.StatePressed.Content.ShortText.Color2 = Color.White;
            btnSave.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.TabIndex = 115;
            btnSave.Values.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // cbPorts
            // 
            cbPorts.Anchor = AnchorStyles.Top;
            cbPorts.DropDownWidth = 152;
            cbPorts.IntegralHeight = false;
            cbPorts.Location = new Point(420, 201);
            cbPorts.Name = "cbPorts";
            cbPorts.Size = new Size(230, 36);
            cbPorts.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbPorts.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbPorts.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbPorts.StateCommon.ComboBox.Border.Rounding = 18F;
            cbPorts.StateCommon.ComboBox.Border.Width = 2;
            cbPorts.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbPorts.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbPorts.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbPorts.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbPorts.StateCommon.DropBack.Color1 = Color.White;
            cbPorts.StateCommon.DropBack.Color2 = Color.White;
            cbPorts.TabIndex = 114;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(430, 241);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 123;
            label1.Text = "Baud Rate";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbBaudRate
            // 
            cbBaudRate.Anchor = AnchorStyles.Top;
            cbBaudRate.DropDownWidth = 152;
            cbBaudRate.IntegralHeight = false;
            cbBaudRate.Location = new Point(420, 273);
            cbBaudRate.Name = "cbBaudRate";
            cbBaudRate.Size = new Size(230, 36);
            cbBaudRate.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(0, 0, 64);
            cbBaudRate.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(0, 0, 64);
            cbBaudRate.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbBaudRate.StateCommon.ComboBox.Border.Rounding = 18F;
            cbBaudRate.StateCommon.ComboBox.Border.Width = 2;
            cbBaudRate.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbBaudRate.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbBaudRate.StateCommon.ComboBox.Content.Padding = new Padding(-1, -1, -1, -10);
            cbBaudRate.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbBaudRate.StateCommon.DropBack.Color1 = Color.White;
            cbBaudRate.StateCommon.DropBack.Color2 = Color.White;
            cbBaudRate.TabIndex = 122;
            // 
            // ControllerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(cbBaudRate);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(cbPorts);
            Name = "ControllerControl";
            Size = new Size(1070, 551);
            Load += ControllerControl_Load;
            ((System.ComponentModel.ISupportInitialize)cbPorts).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbBaudRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label4;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonComboBox cbPorts;
        private Label label1;
        private Krypton.Toolkit.KryptonComboBox cbBaudRate;
    }
}
