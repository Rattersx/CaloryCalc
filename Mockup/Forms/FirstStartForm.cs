using Mockup.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup.Forms
{
    public partial class FirstStartForm : Form
    {
        ThemeInfo theme = new ThemeInfo();
        public FirstStartForm()
        {
            InitializeComponent();
            theme.SetMainPage(Color.FromArgb(21, 101, 192), Color.FromArgb(21, 101, 192), Color.FromArgb(33, 150, 243),
                Color.FromArgb(33, 180, 255), Color.White, Color.FromArgb(233, 237, 240), false);
            guna2GradientPanel1.FillColor = theme.MenuColor1.Value;
            guna2GradientPanel1.FillColor2 = theme.MenuColor2.Value;
            guna2Button4.ForeColor = theme.ButtonTheme.Value;
            label3.ForeColor = theme.ButtonTheme.Value;
            guna2ShadowPanel1.FillColor = theme.TitleColor1.Value;
            panel1.BackColor = theme.ContainerTheme.Value;
            label1.ForeColor = Color.Black;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            theme.SetMainPage(Color.Turquoise, Color.Cyan, Color.Turquoise,
                Color.LightSteelBlue, Color.Black, Color.LightCyan,true);
            guna2GradientPanel1.FillColor = theme.MenuColor1.Value;
            guna2GradientPanel1.FillColor2 = theme.MenuColor2.Value;
            guna2Button4.ForeColor = theme.ButtonTheme.Value;
            label3.ForeColor = theme.ButtonTheme.Value;
            guna2ShadowPanel1.FillColor = theme.ContainerTheme.Value;
            panel1.BackColor = theme.ContainerTheme.Value;
            label1.ForeColor = Color.Black;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            theme.SetMainPage(Color.FromArgb(46, 51, 73), Color.FromArgb(24, 30, 54), Color.FromArgb(19, 26, 46),
                Color.FromArgb(27, 39, 65), Color.FromArgb(0, 126, 249), Color.FromArgb(24, 30, 54), false);
            guna2GradientPanel1.FillColor = theme.MenuColor1.Value;
            guna2GradientPanel1.FillColor2 = theme.MenuColor2.Value;
            guna2Button4.ForeColor = theme.ButtonTheme.Value;
            label3.ForeColor = theme.ButtonTheme.Value;
            guna2ShadowPanel1.FillColor = theme.ContainerTheme.Value;
            panel1.BackColor = theme.ContainerTheme.Value;
            label1.ForeColor = Color.White;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            theme.SetMainPage(Color.FromArgb(21, 101, 192), Color.FromArgb(21, 101, 192), Color.FromArgb(33, 150, 243),
                Color.FromArgb(33, 180, 255), Color.White, Color.FromArgb(233, 237, 240), false);
            guna2GradientPanel1.FillColor = theme.MenuColor1.Value;
            guna2GradientPanel1.FillColor2 = theme.MenuColor2.Value;
            guna2Button4.ForeColor = theme.ButtonTheme.Value;
            label3.ForeColor = theme.ButtonTheme.Value;
            guna2ShadowPanel1.FillColor = theme.TitleColor1.Value;
            panel1.BackColor = theme.ContainerTheme.Value;
            label1.ForeColor = Color.Black;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            theme.SaveTheme();
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
