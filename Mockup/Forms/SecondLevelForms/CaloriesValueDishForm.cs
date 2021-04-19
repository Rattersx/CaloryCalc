using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mockup.Forms.SecondLevelForms
{
    public partial class CaloriesValueDishForm : Form
    {
        bool productListExpand = false;
        Themes.ThemeInfo theme = null;
        public CaloriesValueDishForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            ProductContainer.Width = 0;
        }
        private void ExpandPanel()
        {
            productListExpand = true;

            if (Program.parent.WindowState != FormWindowState.Maximized)
            {
                while (Program.parent.Width != 1420)
                    Program.parent.Width += 110;
                while (ProductContainer.Width != 220)
                    ProductContainer.Width += 110;
            }
            while (ProductContainer.Width != 220)
                ProductContainer.Width += 110;
        }
        private void MinimizePanel()
        {
            productListExpand = false;

            if (Program.parent.WindowState != FormWindowState.Maximized)
            {
                while (Program.parent.Width != 1200)
                    Program.parent.Width -= 110;
                while (ProductContainer.Width != 0)
                    ProductContainer.Width -= 110;
            }
            while (ProductContainer.Width != 0)
                ProductContainer.Width -= 110;
        }
        // При двойном клике на эллемент, должна происходить инициализация продуктов выбранного блюда
        private void dishListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dishListBox.SelectedItem != null)
            {
                ExpandPanel();
            }
        }
        private void productListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(productListBox.SelectedItem != null)
            {
                Form fc = Application.OpenForms["CaloriesValueDish_ProductInfo"];
                if (fc != null)
                    fc.Close();

                CaloriesValueDish_ProductInfo form = new CaloriesValueDish_ProductInfo(theme);
                form.Show();
            }
        }
    }
}
