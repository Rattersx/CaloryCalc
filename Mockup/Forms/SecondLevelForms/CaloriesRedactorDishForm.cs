using Guna.UI2.WinForms;
using Mockup.Forms.SecondLevelForms.AddEditForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup.Forms.SecondLevelForms
{
    public partial class CaloriesRedactorDishForm : Form
    {
        Themes.ThemeInfo theme = null;
        public CaloriesRedactorDishForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            Container.BackColor = theme.ContainerTheme.Value;
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CaloriesRedactorDish_Edit form = new CaloriesRedactorDish_Edit(theme, true);
            form.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CaloriesRedactorDish_Edit form = new CaloriesRedactorDish_Edit(theme, false);
            form.ShowDialog();
        }
    }
}
