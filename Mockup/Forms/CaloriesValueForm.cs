using Guna.UI2.WinForms;
using Mockup.Forms.SecondLevelForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public partial class CaloriesValueForm : Form
    {
        bool productActive = false;
        bool dishActive = false;
        bool productFocused = false;
        bool dishFocused = false;
        Themes.ThemeInfo theme = null;
        public CaloriesValueForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            ProductBorder.Visible = false;
            DishBorder.Visible = false;
            panel1.BackColor = theme.MenuColor1.Value;

            ProductBorder.FillColor = theme.ButtonFill.Value;
            DishBorder.FillColor = theme.ButtonFill.Value;
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
        private void CaloriesValueForm_Load(object sender, EventArgs e)
        {
            AddFormToContainer(new CaloriesValueProductForm(theme));
            ProductBorder.Visible = true;

            ProductButton.FillColor = theme.ContainerTheme.Value;
            ProductBorder.FillColor = theme.ContainerTheme.Value;
            ProductButton.ForeColor = theme.InterfaceLabelTheme.Value;
            ProductButton.HoverState.FillColor = theme.ContainerTheme.Value;
            ProductButton.CheckedState.FillColor = theme.ContainerTheme.Value;
            ProductButton.PressedDepth = 0;
        }
        private void DishButton_Click(object sender, EventArgs e)
        {
            if (!dishFocused)
            {
                dishFocused = true;
                productFocused = false;
                ProductButton.FillColor = theme.ButtonFill.Value;
                ProductButton.ForeColor = theme.ButtonForeColor.Value;
                ProductButton.HoverState.FillColor = Color.Empty;
                ProductButton.CheckedState.FillColor = Color.Empty;
                ProductButton.PressedDepth = 30;

                DishButton.FillColor = theme.ContainerTheme.Value;
                DishBorder.FillColor = theme.ContainerTheme.Value;
                DishButton.ForeColor = theme.InterfaceLabelTheme.Value;
                DishButton.HoverState.FillColor = theme.ContainerTheme.Value;
                DishButton.CheckedState.FillColor = theme.ContainerTheme.Value;
                DishButton.PressedDepth = 0;

                ProductBorder.Visible = false;
                DishBorder.Visible = true;
                AddFormToContainer(new CaloriesValueDishForm(theme));
            }
        }
        private void ProductButton_Click(object sender, EventArgs e)
        {
            Program.parent.Width = 1200;
            if (!productFocused)
            {
                dishFocused = false;
                productFocused = true;
                DishButton.FillColor = theme.ButtonFill.Value;
                DishButton.ForeColor = theme.ButtonForeColor.Value;
                DishButton.HoverState.FillColor = Color.Empty;
                DishButton.CheckedState.FillColor = Color.Empty;
                DishButton.PressedDepth = 30;

                ProductButton.FillColor = theme.ContainerTheme.Value;
                ProductBorder.FillColor = theme.ContainerTheme.Value;
                ProductButton.ForeColor = theme.InterfaceLabelTheme.Value;
                ProductButton.HoverState.FillColor = theme.ContainerTheme.Value;
                ProductButton.CheckedState.FillColor = theme.ContainerTheme.Value;
                ProductButton.PressedDepth = 0;

                ProductBorder.Visible = true;
                DishBorder.Visible = false;

                AddFormToContainer(new CaloriesValueProductForm(theme));
            }
        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
