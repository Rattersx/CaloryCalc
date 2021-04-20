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
                timer2.Start();
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

        public void AddnewProduct()
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    if (titleTB.Text != "")
                    {
                        Product addproduct = new Product
                        {
                            Name = titleTB.Text,
                            Description = descriptionTB.Text,
                            Kcal = Convert.ToDouble(CaloriesTB.Text),
                            Ffat = Convert.ToDouble(FatTB.Text),
                            Carbohydrate = Convert.ToDouble(CarbohydrTB.Text),
                            Protein = Convert.ToDouble(ProteinTB.Text),
                            IsAlergic = YesRB.Checked,
                            Density = Convert.ToDouble(densityTB.Text),
                        };
                        var allproducts = db.Products.ToList();
                        foreach (Product item in allproducts)
                        {
                            if (item.Name == addproduct.Name)
                            {
                                throw new Exception("Такой продукт уже добавлен!");
                            }
                        }
                        db.Products.Add(addproduct);
                        db.SaveChanges();
                        MessageBox.Show("Продукт добавлен.");
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (this.Width != 490)
                this.Width += 15;
            if (AcceptButton.Width != 240)
                AcceptButton.Width += 7;
        }
        public void AddNewProduct()
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    if (titleTB.Text != "")
                    {
                        Product addproduct = new Product
                        {
                            Name = titleTB.Text,
                            Description = descriptionTB.Text,
                            Kcal = Convert.ToDouble(CaloriesTB.Text),
                            Ffat = Convert.ToDouble(FatTB.Text),
                            Carbohydrate = Convert.ToDouble(CarbohydrTB.Text),
                            Protein = Convert.ToDouble(ProteinTB.Text),
                            IsAlergic = YesRB.Checked,
                            Density = Convert.ToDouble(densityTB.Text),
                        };
                        var allproducts = db.Products.ToList();
                        foreach (Product item in allproducts)
                        {
                            if (item.Name == addproduct.Name)
                            {
                                throw new Exception("Такой продукт уже добавлен!");
                            }
                        }
                        db.Products.Add(addproduct);
                        db.SaveChanges();
                        MessageBox.Show("Продукт добавлен.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            AddNewProduct();
        }
    }
}
