using homeWorkLesson8_4.SettingsManager;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace homeWorkLesson8_4
{
    public partial class MainForm : Form
    {
        private ISettingsManager settingsManager;

        public MainForm()
        {
            InitializeComponent();

            settingsManager = new AppConfigSettingsManagerModel();
            //settingsManager = new RegistrySettingsManagerModel();

            LoadSettings();
        }

        private void LoadSettings()
        {
            if (!settingsManager.Load(out var backColor, out var foreColor, out var fontSize, out var fontStyle))
            {
                MessageBox.Show(
                    "Не удалось считать настройки, будут применены значения по умолчанию!",
                    "Ошибка",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }

            //apply settings
            exampleLabel.BackColor = btnBackgroundColor.BackColor = backColor;
            exampleLabel.ForeColor = btnFontColor.BackColor = foreColor;
            nudFontSize.Value = Convert.ToDecimal(fontSize);
            cbFontStyle.SelectedIndex = (int)fontStyle;
            exampleLabel.Font = new Font("Arial", fontSize, fontStyle);
        }

        private void btnBackgroundColor_Click(object sender, System.EventArgs e)
        {
            var colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                exampleLabel.BackColor = btnBackgroundColor.BackColor = colorDlg.Color;
            }
        }

        private void btnFontColor_Click(object sender, System.EventArgs e)
        {
            var colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                exampleLabel.ForeColor = btnFontColor.BackColor = colorDlg.Color;
            }
        }

        private void Font_ValueChanged(object sender, System.EventArgs e)
        {
            exampleLabel.Font = new Font("Arial", (float)nudFontSize.Value, (FontStyle)cbFontStyle.SelectedIndex);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (settingsManager.Save(exampleLabel.BackColor, exampleLabel.ForeColor, exampleLabel.Font.Size, exampleLabel.Font.Style))
            {
                MessageBox.Show(
                    "Настройки успешно сохранены!",
                    "Уведомление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Настройки не удалось сохранить!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
