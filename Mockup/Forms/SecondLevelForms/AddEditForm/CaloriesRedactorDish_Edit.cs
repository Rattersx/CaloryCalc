using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup.Forms.SecondLevelForms.AddEditForm
{
    public partial class CaloriesRedactorDish_Edit : Form
    {
        Themes.ThemeInfo theme = new Themes.ThemeInfo();
        public CaloriesRedactorDish_Edit(Themes.ThemeInfo _theme, bool isAdd)
        {
            InitializeComponent();
            theme = _theme;
            AnimateWindow.SetAnimateWindow(this);
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
            if (isAdd)
                bunifuCustomLabel1.Text = "Добавить";
            else
                bunifuCustomLabel1.Text = "Изменить";
            Commands.ApplyTheme(this, theme);
            if(theme.black)
            {
                guna2ImageButton1.Image = blackList.Images[0];
                guna2ImageButton2.Image = blackList.Images[1];
            }
            else
            {
                guna2ImageButton1.Image = blueList.Images[0];
                guna2ImageButton2.Image = blueList.Images[1];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.ForeColor = guna2ColorTransition1.Value;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
