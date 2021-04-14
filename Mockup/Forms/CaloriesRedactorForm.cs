using Guna.UI2.WinForms;
using Mockup.Forms.SecondLevelForms;
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
    public partial class CaloriesRedactorForm : Form
    {
        Themes.ThemeInfo theme = new Themes.ThemeInfo();
        public CaloriesRedactorForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, Container, theme);
        }
        private void AddFormToContainer(object form)
        {
            foreach (Control item in Container.Controls)
            {
                Container.Controls.Remove(item);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            Container.Controls.Add(f);
            Container.Tag = f;
            f.Visible = true;
            f.Show();
        }

        private void CaloriesRedactorForm_Load(object sender, EventArgs e)
        {
            AddFormToContainer(new CaloriesRedactorProductForm(theme));
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (guna2Button4.Dock == DockStyle.Left)
            {
                guna2Button4.Dock = DockStyle.None;
                guna2Button4.Location = new Point(0, 0);
                while (guna2Button4.Location.X != 709)
                    guna2Button4.Location = new Point(guna2Button4.Location.X + 1, guna2Button4.Location.Y);
                guna2Button4.Dock = DockStyle.Right;
                AddFormToContainer(new CaloriesRedactorDishForm(theme));
            }
            else
            {
                guna2Button4.Dock = DockStyle.None;
                guna2Button4.Location = new Point(709, 0);
                while (guna2Button4.Location.X != 0)
                    guna2Button4.Location = new Point(guna2Button4.Location.X - 1, guna2Button4.Location.Y);
                guna2Button4.Dock = DockStyle.Left;
                AddFormToContainer(new CaloriesRedactorProductForm(theme));
            }
        }
    }
}
