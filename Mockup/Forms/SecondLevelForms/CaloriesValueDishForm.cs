using System;
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

            panel24.BackColor = theme.MenuColor1.Value;
            productListExpand = false;

            if (theme.black)
                guna2Button1.Image = blackList.Images[0];
            else
                guna2Button1.Image = blueList.Images[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(productListExpand)
            {
                productListExpand = false;

                if (theme.black)
                    guna2Button1.Image = blackList.Images[0];
                else
                    guna2Button1.Image = blueList.Images[0];

                while (Program.parent.Width != 1200)
                    Program.parent.Width -= 110;
                while (ProductContainer.Width != 30)
                    ProductContainer.Width -= 110;
            }
            else
            {
                productListExpand = true;

                if (theme.black)
                    guna2Button1.Image = blackList.Images[1];
                else
                    guna2Button1.Image = blueList.Images[1];
                while (Program.parent.Width != 1420)
                    Program.parent.Width += 110;
                while (ProductContainer.Width != 250)
                    ProductContainer.Width += 110;
                ProductContainer.Width = 250;
            }
        }
    }
}
