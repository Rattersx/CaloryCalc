using Mockup.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mockup
{
    public partial class SettingsForm : Form
    {
        ThemeInfo theme = new ThemeInfo();
        public SettingsForm(ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            ApplyTheme();

            var labels = Commands.GetAllControls(this, typeof(Label));

            ActivateRadioButtonFromTheme();
        }
        private void ActivateRadioButtonFromTheme()
        {
            if (label4.Text == theme.title)
            {
                guna2CustomRadioButton2.Checked = true;
            }
            else if (label8.Text == theme.title)
            {
                guna2CustomRadioButton1.Checked = true;
            }
            else if (label9.Text == theme.title)
            {
                guna2CustomRadioButton3.Checked = true;
            }
        }
        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CustomRadioButton2.Checked)
            {
                theme.title = "ClassicBlue";
                theme.SetMainPage(Color.FromArgb(21, 101, 192), Color.FromArgb(21, 101, 192), Color.FromArgb(33, 150, 243),
                Color.FromArgb(33, 180, 255), Color.White, Color.FromArgb(233, 237, 240), false);
                theme.SetComboBox(Color.White, Color.PaleTurquoise, Color.FromArgb(217, 221, 226), Color.PowderBlue,
                    Color.Black);
                theme.SetTextBoxTheme(Color.White, Color.PaleTurquoise, Color.FromArgb(217, 221, 226), Color.PowderBlue,
                    Color.Black);
                theme.SetPanelAnimation(Color.FromArgb(198, 201, 204), Color.FromArgb(139, 141, 143));
                theme.SetButton(Color.FromArgb(94, 148, 255), Color.Black, Color.FromArgb(94, 148, 255), Color.White);
                theme.SetInterfaceLabelTheme(Color.Black);
                theme.SetProgressBar(Color.SteelBlue, Color.FromArgb(192, 192, 255), Color.FromArgb(172, 122, 230));
                theme.SetListView(Color.LightCyan, Color.LightSkyBlue, Color.Black);
                theme.SaveTheme();
                ApplyTheme();
            }
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton1.Checked)
            { 
                theme.title = "DarkBlue";
                theme.SetMainPage(Color.FromArgb(46, 51, 73), Color.FromArgb(24, 30, 54), Color.FromArgb(19, 26, 46),
                    Color.FromArgb(27, 39, 65), Color.PowderBlue, Color.FromArgb(24, 30, 54), false);
                theme.SetPanelAnimation(Color.FromArgb(59, 64, 84), Color.FromArgb(139, 141, 143));
                theme.SetComboBox(Color.SteelBlue, Color.Azure, Color.Black, Color.White, Color.White);
                theme.SetTextBoxTheme(Color.LightSteelBlue, Color.Azure, Color.Black, Color.White, Color.White);
                theme.SetButton(Color.LightSteelBlue, Color.Black, Color.LightSteelBlue, Color.Black);
                theme.SetProgressBar(Color.RoyalBlue, Color.FromArgb(192, 192, 255), Color.CornflowerBlue);
                theme.SetInterfaceLabelTheme(Color.PowderBlue);
                theme.SetListView(Color.FromArgb(54, 60, 104), Color.SteelBlue, Color.White);
                theme.SaveTheme();
                ApplyTheme();
            }
        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton3.Checked)
            {
                theme.title = "LightSky";
                theme.SetMainPage(Color.Turquoise, Color.Cyan, Color.Turquoise,
                    Color.LightSteelBlue, Color.Black, Color.LightCyan, true);
                theme.SetInterfaceLabelTheme(Color.Black);
                theme.SetComboBox(Color.White, Color.PaleTurquoise, Color.FromArgb(217, 221, 226), Color.PowderBlue,
    Color.Black);
                theme.SetPanelAnimation(Color.FromArgb(190, 217, 217), Color.FromArgb(133,152,152));
                theme.SetTextBoxTheme(Color.LightSteelBlue, Color.Azure, Color.Black, Color.White, Color.White);
                theme.SetButton(Color.PaleTurquoise, Color.Black, Color.FromArgb(94, 148, 255), Color.Black);
                theme.SetProgressBar(Color.FromArgb(0, 197, 199), Color.FromArgb(192, 192, 255), Color.RoyalBlue);
                theme.SetListView(Color.White, Color.PaleTurquoise, Color.Black);
                theme.SaveTheme();
                ApplyTheme();
            }
        }
        private void ApplyTheme()
        {
            this.BackColor = theme.ContainerTheme.Value;
            Program.parent.ThemeReload();

            var labels = Commands.GetAllControls(this, typeof(Label));
            foreach (Control label in labels)
            {
                label.ForeColor = theme.InterfaceLabelTheme.Value;
            }
        }
    }
}
