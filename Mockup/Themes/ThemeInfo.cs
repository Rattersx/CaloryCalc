using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Mockup.Themes
{
    [Serializable]
    public class ThemeInfo
    {
        public string title { get; set; }

        #region MainPage
        public ColorHolder MenuColor1 = new ColorHolder();
        public ColorHolder MenuColor2 = new ColorHolder();
        public ColorHolder TitleColor1 = new ColorHolder();
        public ColorHolder TitleColor2 = new ColorHolder();
        public ColorHolder ButtonTheme = new ColorHolder();
        public ColorHolder ContainerTheme = new ColorHolder();
        public ColorHolder InterfaceLabelTheme = new ColorHolder();
        #endregion
        #region TextBox
        public ColorHolder TextBoxFill = new ColorHolder();
        public ColorHolder TextBoxHold = new ColorHolder();
        public ColorHolder TextBoxCheckedBorder = new ColorHolder();
        public ColorHolder TextBoxBorder = new ColorHolder();
        public ColorHolder TextBoxCheckedForeColor = new ColorHolder();
        #endregion
        #region ComboBox
        public ColorHolder ComboBoxFill = new ColorHolder();
        public ColorHolder ComboBoxHold = new ColorHolder();
        public ColorHolder ComboBoxBorder = new ColorHolder();
        public ColorHolder ComboBoxCheckedBorder = new ColorHolder();
        public ColorHolder ComboBoxCheckedForeColor = new ColorHolder();
        #endregion
        #region Button
        public ColorHolder ButtonFill = new ColorHolder();
        public ColorHolder ButtonBorder = new ColorHolder();
        public ColorHolder ButtonShadowColor = new ColorHolder();
        public ColorHolder ButtonForeColor = new ColorHolder();
        #endregion
        #region listView
        public ColorHolder ListViewFill = new ColorHolder();
        public ColorHolder ListViewBorderFill = new ColorHolder();
        public ColorHolder ListViewForeColor = new ColorHolder();
        #endregion
        #region progressBar
        public ColorHolder progressBarFill = new ColorHolder();
        public ColorHolder progressBarValue1 = new ColorHolder();
        public ColorHolder progressBarValue2 = new ColorHolder();
        #endregion
        #region panelAnimation
        public ColorHolder panelHover = new ColorHolder();
        public ColorHolder panelClick = new ColorHolder();
        #endregion


        public bool black { get; set; }
        public ThemeInfo() { }
        public void SetMainPage(Color gradient1, Color gradient2, Color titleColor1, Color titleColor2, Color buttonColor, Color containerColor, bool style)
        {
            MenuColor1.Value = gradient1;
            MenuColor2.Value = gradient2;
            TitleColor1.Value = titleColor1;
            TitleColor2.Value = titleColor2;
            ButtonTheme.Value = buttonColor;
            ContainerTheme.Value = containerColor;
            black = style;
        }
        public void SetInterfaceLabelTheme(Color color)
        {
            InterfaceLabelTheme.Value = color;
        }
        public void SetPanelAnimation(Color hover, Color click)
        {
            panelHover.Value = hover;
            panelClick.Value = click;
        }
        public void SetTextBoxTheme(Color fill, Color hold, Color border, Color focusedBorder, Color checked_ForeColor)
        {
            TextBoxFill.Value = fill;
            TextBoxHold.Value = hold;
            TextBoxBorder.Value = border;
            TextBoxCheckedBorder.Value = focusedBorder;
            TextBoxCheckedForeColor.Value = checked_ForeColor;
        }
        public void SetComboBox(Color fill, Color hold, Color border, Color focusedBorder, Color checked_ForeColor)
        {
            ComboBoxFill.Value = fill;
            ComboBoxHold.Value = hold;
            ComboBoxBorder.Value = border;
            ComboBoxCheckedBorder.Value = focusedBorder;
            ComboBoxCheckedForeColor.Value = checked_ForeColor;
        }
        public void SetButton(Color fill, Color border, Color shadowColor, Color foreColor)
        {
            ButtonFill.Value = fill;
            ButtonBorder.Value = border;
            ButtonShadowColor.Value = shadowColor;
            ButtonForeColor.Value = foreColor;
        }
        public void SetProgressBar(Color fill, Color value1, Color value2)
        {
            progressBarFill.Value = fill;
            progressBarValue1.Value = value1;
            progressBarValue2.Value = value2;
        }
        public void SetListView(Color fill, Color borderFill, Color foreColor)
        {
            ListViewFill.Value = fill;
            ListViewBorderFill.Value = borderFill;
            ListViewForeColor.Value = foreColor;
        }
        public void SaveTheme()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter("theme.json"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, this);
                }
            }
        }
        public void GetTheme()
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (StreamReader sw = new StreamReader("theme.json"))
                {
                    SetElements(JsonConvert.DeserializeObject<ThemeInfo>(sw.ReadToEnd()));
                }
            }
            catch { }
        }
        public void SetElements(ThemeInfo obj)
        {
            title = obj.title;

            MenuColor1.Value = obj.MenuColor1.Value;
            MenuColor2.Value = obj.MenuColor2.Value;
            TitleColor1.Value = obj.TitleColor1.Value;
            TitleColor2.Value = obj.TitleColor2.Value;
            ButtonTheme.Value = obj.ButtonTheme.Value;
            ContainerTheme.Value = obj.ContainerTheme.Value;

            InterfaceLabelTheme.Value = obj.InterfaceLabelTheme.Value;

            ComboBoxFill.Value = obj.ComboBoxFill.Value;
            ComboBoxHold.Value = obj.ComboBoxHold.Value;
            ComboBoxBorder.Value = obj.ComboBoxBorder.Value;
            ComboBoxCheckedBorder.Value = obj.ComboBoxCheckedBorder.Value;
            ComboBoxCheckedForeColor.Value = obj.ComboBoxCheckedForeColor.Value;

            TextBoxFill.Value = obj.TextBoxFill.Value;
            TextBoxHold.Value = obj.TextBoxHold.Value;
            TextBoxBorder.Value = obj.TextBoxBorder.Value;
            TextBoxCheckedBorder.Value = obj.TextBoxCheckedBorder.Value;
            TextBoxCheckedForeColor.Value = obj.TextBoxCheckedForeColor.Value;

            ButtonFill.Value = obj.ButtonFill.Value;
            ButtonBorder.Value = obj.ButtonBorder.Value;
            ButtonShadowColor.Value = obj.ButtonShadowColor.Value;
            ButtonForeColor.Value = obj.ButtonForeColor.Value;

            progressBarFill.Value = obj.progressBarFill.Value;
            progressBarValue1.Value = obj.progressBarValue1.Value;
            progressBarValue2.Value = obj.progressBarValue2.Value;

            ListViewFill.Value = obj.ListViewFill.Value;
            ListViewBorderFill.Value = obj.ListViewBorderFill.Value;
            ListViewForeColor.Value = obj.ListViewForeColor.Value;

            panelHover.Value = obj.panelHover.Value;
            panelClick.Value = obj.panelClick.Value;

            black = obj.black;
        }
        public class ColorHolder
        {
            public Color Value { get; set; }
        }
    }
}
