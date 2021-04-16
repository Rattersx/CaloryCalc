using Guna.UI2.WinForms;
using Mockup.Forms.AddForms;
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
    public partial class CaloriesRedactorProductForm : Form
    {
        Themes.ThemeInfo theme = null;
        public CaloriesRedactorProductForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            Container.BackColor = theme.ContainerTheme.Value;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CaloriesRedactorProductAdd form = new CaloriesRedactorProductAdd(theme, true);
            form.ShowDialog();
        }
    }
}
