using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public class Commands
    {
        static public IEnumerable<Control> GetAllControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        static public void ApplyTheme(Form form, Themes.ThemeInfo theme)
        {

            form.BackColor = theme.ContainerTheme.Value;

            var panels = GetAllControls(form, typeof(Panel));
            var labels = GetAllControls(form, typeof(Label));
            var labelsVar2 = GetAllControls(form, typeof(Bunifu.Framework.UI.BunifuCustomLabel));
            var radioButtons = GetAllControls(form, typeof(RadioButton));
            var comboBoxes = GetAllControls(form, typeof(Guna2ComboBox));
            var textBoxes = GetAllControls(form, typeof(Guna2TextBox));
            var textBoxesVar2 = GetAllControls(form, typeof(Bunifu.Framework.UI.BunifuTextbox));
            var buttons = GetAllControls(form, typeof(Guna2Button));
            var progressBars = GetAllControls(form, typeof(Guna2ProgressBar));
            var GroupBoxes = GetAllControls(form, typeof(Guna2GroupBox));
            var listViews = GetAllControls(form, typeof(ListBox));
            var tileButtons = GetAllControls(form, typeof(Guna2TileButton));

            foreach (Control label in labels)
            {
                label.ForeColor = theme.InterfaceLabelTheme.Value;
            }
            foreach (Control label in labelsVar2)
            {
                label.ForeColor = theme.InterfaceLabelTheme.Value;
            }
            foreach (Control button in radioButtons)
            {
                button.ForeColor = theme.InterfaceLabelTheme.Value;
            }
            foreach (Guna2ComboBox box in comboBoxes)
            {
                box.FillColor = theme.ComboBoxFill.Value;
                box.HoverState.FillColor = theme.ComboBoxHold.Value;
                box.BorderColor = theme.ComboBoxBorder.Value;
                box.ForeColor = theme.InterfaceLabelTheme.Value;
                box.FocusedState.ForeColor = theme.ComboBoxCheckedForeColor.Value;
                box.FocusedState.BorderColor = theme.ComboBoxCheckedBorder.Value;
            }
            foreach (Guna2TextBox box in textBoxes)
            {
                box.FillColor = theme.TextBoxFill.Value;
                box.HoverState.FillColor = theme.TextBoxHold.Value;
                box.BorderColor = theme.TextBoxBorder.Value;
                box.ForeColor = theme.InterfaceLabelTheme.Value;
                box.FocusedState.ForeColor = theme.TextBoxCheckedForeColor.Value;
                box.FocusedState.BorderColor = theme.TextBoxCheckedBorder.Value;
            }
            foreach (Guna2TextBox box in textBoxesVar2)
            {
                box.FillColor = theme.TextBoxFill.Value;
                box.HoverState.FillColor = theme.TextBoxHold.Value;
                box.BorderColor = theme.TextBoxBorder.Value;
                box.ForeColor = theme.InterfaceLabelTheme.Value;
                box.FocusedState.ForeColor = theme.TextBoxCheckedForeColor.Value;
                box.FocusedState.BorderColor = theme.TextBoxCheckedBorder.Value;
            }
            foreach (Guna2Button button in buttons)
            {
                button.FillColor = theme.ButtonFill.Value;
                button.ForeColor = theme.ButtonForeColor.Value;
                button.ShadowDecoration.Color = theme.ButtonShadowColor.Value;
                button.BorderColor = theme.ButtonBorder.Value;
            }
            foreach (Guna2ProgressBar bar in progressBars)
            {
                bar.FillColor = theme.progressBarFill.Value;
                bar.ProgressColor = theme.progressBarValue1.Value;
                bar.ProgressColor2 = theme.progressBarValue2.Value;
            }
            foreach (Guna2GroupBox box in GroupBoxes)
            {
                box.CustomBorderColor = theme.ListViewBorderFill.Value;
            }
            foreach (ListBox lv in listViews)
            {
                lv.ForeColor = theme.ListViewForeColor.Value;
                lv.BackColor = theme.ListViewFill.Value;
            }
            foreach (Guna2TileButton button in tileButtons)
            {
                button.FillColor = theme.ButtonFill.Value;
                button.ForeColor = theme.ButtonForeColor.Value;
                button.ShadowDecoration.Color = theme.ButtonShadowColor.Value;
                button.BorderColor = theme.ButtonBorder.Value;
            }
        }

    }
}
