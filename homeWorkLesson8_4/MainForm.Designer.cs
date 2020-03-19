namespace homeWorkLesson8_4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.textPage = new System.Windows.Forms.TabPage();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.settingsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.labelBackgroundColor = new System.Windows.Forms.Label();
            this.labelFontColor = new System.Windows.Forms.Label();
            this.labelFontStyle = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.cbFontStyle = new System.Windows.Forms.ComboBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.textPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.settingsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.textPage);
            this.mainTabControl.Controls.Add(this.settingsPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(361, 188);
            this.mainTabControl.TabIndex = 0;
            // 
            // textPage
            // 
            this.textPage.Controls.Add(this.exampleLabel);
            this.textPage.Location = new System.Drawing.Point(4, 22);
            this.textPage.Name = "textPage";
            this.textPage.Padding = new System.Windows.Forms.Padding(3);
            this.textPage.Size = new System.Drawing.Size(353, 162);
            this.textPage.TabIndex = 0;
            this.textPage.Text = "Text";
            this.textPage.UseVisualStyleBackColor = true;
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exampleLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exampleLabel.Location = new System.Drawing.Point(3, 3);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(70, 14);
            this.exampleLabel.TabIndex = 0;
            this.exampleLabel.Text = "Example Text";
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.settingsLayoutPanel);
            this.settingsPage.Controls.Add(this.btnSaveSettings);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(353, 162);
            this.settingsPage.TabIndex = 1;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // settingsLayoutPanel
            // 
            this.settingsLayoutPanel.ColumnCount = 2;
            this.settingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsLayoutPanel.Controls.Add(this.btnFontColor, 1, 1);
            this.settingsLayoutPanel.Controls.Add(this.labelBackgroundColor, 0, 0);
            this.settingsLayoutPanel.Controls.Add(this.labelFontColor, 0, 1);
            this.settingsLayoutPanel.Controls.Add(this.labelFontStyle, 0, 3);
            this.settingsLayoutPanel.Controls.Add(this.nudFontSize, 1, 2);
            this.settingsLayoutPanel.Controls.Add(this.labelFontSize, 0, 2);
            this.settingsLayoutPanel.Controls.Add(this.cbFontStyle, 1, 3);
            this.settingsLayoutPanel.Controls.Add(this.btnBackgroundColor, 1, 0);
            this.settingsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.settingsLayoutPanel.Name = "settingsLayoutPanel";
            this.settingsLayoutPanel.RowCount = 4;
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.Size = new System.Drawing.Size(347, 133);
            this.settingsLayoutPanel.TabIndex = 0;
            // 
            // btnFontColor
            // 
            this.btnFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontColor.Location = new System.Drawing.Point(176, 38);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(168, 23);
            this.btnFontColor.TabIndex = 7;
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // labelBackgroundColor
            // 
            this.labelBackgroundColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBackgroundColor.AutoSize = true;
            this.labelBackgroundColor.Location = new System.Drawing.Point(3, 10);
            this.labelBackgroundColor.Name = "labelBackgroundColor";
            this.labelBackgroundColor.Size = new System.Drawing.Size(64, 13);
            this.labelBackgroundColor.TabIndex = 0;
            this.labelBackgroundColor.Text = "Цвет фона:";
            // 
            // labelFontColor
            // 
            this.labelFontColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFontColor.AutoSize = true;
            this.labelFontColor.Location = new System.Drawing.Point(3, 43);
            this.labelFontColor.Name = "labelFontColor";
            this.labelFontColor.Size = new System.Drawing.Size(72, 13);
            this.labelFontColor.TabIndex = 1;
            this.labelFontColor.Text = "Цвет текста:";
            // 
            // labelFontStyle
            // 
            this.labelFontStyle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFontStyle.AutoSize = true;
            this.labelFontStyle.Location = new System.Drawing.Point(3, 109);
            this.labelFontStyle.Name = "labelFontStyle";
            this.labelFontStyle.Size = new System.Drawing.Size(82, 13);
            this.labelFontStyle.TabIndex = 3;
            this.labelFontStyle.Text = "Стиль шрифта:";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFontSize.Location = new System.Drawing.Point(176, 72);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(168, 20);
            this.nudFontSize.TabIndex = 4;
            this.nudFontSize.ValueChanged += new System.EventHandler(this.Font_ValueChanged);
            // 
            // labelFontSize
            // 
            this.labelFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(3, 76);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(91, 13);
            this.labelFontSize.TabIndex = 2;
            this.labelFontSize.Text = "Размер шрифта:";
            // 
            // cbFontStyle
            // 
            this.cbFontStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontStyle.FormattingEnabled = true;
            this.cbFontStyle.Items.AddRange(new object[] {
            "Regular",
            "Bold",
            "Italic"});
            this.cbFontStyle.Location = new System.Drawing.Point(176, 105);
            this.cbFontStyle.Name = "cbFontStyle";
            this.cbFontStyle.Size = new System.Drawing.Size(168, 21);
            this.cbFontStyle.TabIndex = 5;
            this.cbFontStyle.SelectedIndexChanged += new System.EventHandler(this.Font_ValueChanged);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackgroundColor.Location = new System.Drawing.Point(176, 5);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(168, 23);
            this.btnBackgroundColor.TabIndex = 6;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveSettings.Location = new System.Drawing.Point(3, 136);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(347, 23);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 188);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainTabControl.ResumeLayout(false);
            this.textPage.ResumeLayout(false);
            this.textPage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsLayoutPanel.ResumeLayout(false);
            this.settingsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage textPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.TableLayoutPanel settingsLayoutPanel;
        private System.Windows.Forms.Label labelBackgroundColor;
        private System.Windows.Forms.Label labelFontColor;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Label labelFontStyle;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.ComboBox cbFontStyle;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnFontColor;
    }
}

