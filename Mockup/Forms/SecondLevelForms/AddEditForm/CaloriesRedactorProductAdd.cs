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

namespace Mockup.Forms.AddForms
{
    public partial class CaloriesRedactorProductAdd : Form
    {
        Themes.ThemeInfo theme = null;
        public CaloriesRedactorProductAdd(Themes.ThemeInfo _theme, bool isAdd)
        {
            InitializeComponent();
            AnimateWindow.SetAnimateWindow(this);
            guna2ShadowForm1.SetShadowForm(this);
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            if (isAdd)
                bunifuCustomLabel1.Text = "Добавить";
            else
                bunifuCustomLabel1.Text = "Изменить";
        }
        private void CaloriesRedactorProductAdd_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.ForeColor = guna2ColorTransition1.Value;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void titleTB_TextChanged(object sender, EventArgs e)
        {
            if(titleTB.Text != "")
            {
                Animator.ShowSync(ProteinLabel);
                Animator.ShowSync(ProteinTB);
            }
        }

        private void ProteinTB_TextChanged(object sender, EventArgs e)
        {
            if (ProteinTB.Text != "")
            {
                Animator.ShowSync(FatLabel);
                Animator.ShowSync(FatTB);
            }
        }

        private void FatTB_TextChanged(object sender, EventArgs e)
        {
            if (FatTB.Text != "")
            {
                Animator.ShowSync(CarbohydrLabel);
                Animator.ShowSync(CarbohydrTB);
            }
        }

        private void CaloriesTB_TextChanged(object sender, EventArgs e)
        {
            if (CaloriesTB.Text != "")
            {
                Animator.ShowSync(YesRB);
                Animator.ShowSync(NoRB);
            }
        }

        private void CarbohydrTB_TextChanged(object sender, EventArgs e)
        {
            if(CarbohydrTB.Text != "")
            {
                Animator.ShowSync(CaloriesLabel);
                Animator.ShowSync(CaloriesTB);
            }
        }

        private void YesRB_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRB.Checked == false)
                AcceptButton.Enabled = true;
        }

        private void NoRB_CheckedChanged(object sender, EventArgs e)
        {
            if (YesRB.Checked == false)
                AcceptButton.Enabled = true;
        }
    }
}
