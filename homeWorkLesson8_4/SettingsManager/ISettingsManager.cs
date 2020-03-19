using System.Drawing;

namespace homeWorkLesson8_4.SettingsManager
{
    public interface ISettingsManager
    {
        bool Load(out Color backColor, out Color foreColor, out float fontSize, out FontStyle fontStyle);
        bool Save(Color backColor, Color foreColor, float fontSize, FontStyle fontStyle);
    }
}
