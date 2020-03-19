using System;
using System.Configuration;
using System.Drawing;

namespace homeWorkLesson8_4.SettingsManager
{
    public class AppConfigSettingsManagerModel : ISettingsManager
    {
        public bool Load(out Color backColor, out Color foreColor, out float fontSize, out FontStyle fontStyle)
        {
            try
            {
                backColor = ColorTranslator.FromHtml(ConfigurationManager.AppSettings["BackColor"]);
                foreColor = ColorTranslator.FromHtml(ConfigurationManager.AppSettings["ForeColor"]);
                fontSize = (float)Convert.ToDouble(ConfigurationManager.AppSettings["FontSize"]);
                fontStyle = (FontStyle)Convert.ToInt32(ConfigurationManager.AppSettings["FontStyle"]);
            }
            catch (Exception)
            {
                backColor = Color.White;
                foreColor = Color.Black;
                fontSize = 25.0f;
                fontStyle = FontStyle.Regular;

                return false;
            }

            return true;
        }

        public bool Save(Color backColor, Color foreColor, float fontSize, FontStyle fontStyle)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["BackColor"].Value = ColorTranslator.ToHtml(backColor);
                config.AppSettings.Settings["ForeColor"].Value = ColorTranslator.ToHtml(foreColor);
                config.AppSettings.Settings["FontSize"].Value = Convert.ToString(fontSize);
                config.AppSettings.Settings["FontStyle"].Value = Convert.ToString((int)fontStyle);

                config.Save(ConfigurationSaveMode.Modified);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
