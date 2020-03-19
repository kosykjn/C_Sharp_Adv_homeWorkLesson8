using Microsoft.Win32;
using System;
using System.Drawing;

namespace homeWorkLesson8_4.SettingsManager
{
    public class RegistrySettingsManagerModel : ISettingsManager
    {
        public bool Load(out Color backColor, out Color foreColor, out float fontSize, out FontStyle fontStyle)
        {
            try
            {
                var rootSoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
                var appKey = rootSoftwareKey?.OpenSubKey("KosykApp", false);

                backColor = ColorTranslator.FromHtml((string)appKey.GetValue("BackColor"));
                foreColor = ColorTranslator.FromHtml((string)appKey.GetValue("ForeColor"));
                fontSize = (float)Convert.ToDouble(appKey.GetValue("FontSize"));
                fontStyle = (FontStyle)Convert.ToInt32(appKey.GetValue("FontStyle"));
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
                var rootSoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);

                if (rootSoftwareKey != null)
                {
                    var appKey = rootSoftwareKey.OpenSubKey("KosykApp", true) ?? rootSoftwareKey.CreateSubKey("KosykApp");

                    if (appKey != null)
                    {
                        appKey.SetValue("BackColor", ColorTranslator.ToHtml(backColor));
                        appKey.SetValue("ForeColor", ColorTranslator.ToHtml(foreColor));
                        appKey.SetValue("FontSize", fontSize);
                        appKey.SetValue("FontStyle", (int)fontStyle);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
