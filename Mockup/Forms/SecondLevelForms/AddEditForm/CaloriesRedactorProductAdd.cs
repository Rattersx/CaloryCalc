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
        public object selectedItem;
        bool isAdd = false;
        public CaloriesRedactorProductAdd(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            AnimateWindow.SetAnimateWindow(this);
            guna2ShadowForm1.SetShadowForm(this);
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            bunifuCustomLabel1.Text = "Добавить";
            isAdd = true;
        }
        public CaloriesRedactorProductAdd(Themes.ThemeInfo _theme, Product product)
        {
            InitializeComponent();
            AnimateWindow.SetAnimateWindow(this);
            guna2ShadowForm1.SetShadowForm(this);
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            bunifuCustomLabel1.Text = "Изменить";

            selectedItem = product as Product;
            productInfo(product);
            isAdd = false;
        }
        void productInfo(Product product)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var selectedProduct = db.Products.Where(p => p.Id == product.Id).ToList<Product>();

                titleTB.Text = selectedProduct[0].Name;
                descriptionTB.Text = selectedProduct[0].Description;
                CaloriesTB.Text = selectedProduct[0].Kcal.ToString();
                FatTB.Text = selectedProduct[0].Ffat.ToString();
                CarbohydrTB.Text = selectedProduct[0].Carbohydrate.ToString();
                ProteinTB.Text = selectedProduct[0].Protein.ToString();
                densityTB.Text = selectedProduct[0].Density.ToString();
                if (selectedProduct[0].IsAlergic)
                    YesRB.Checked = true;
                else
                    NoRB.Checked = true;
                //Program.parent.progressEnd = true;
            }
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
            if(isAdd)
                AddNewProduct();
            else
                saveProduct(selectedItem as Product);
        }
        void saveProduct(Product product)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (titleTB.Text.Trim() != "" && CaloriesTB.Text.Trim() != "" && FatTB.Text.Trim() != "" && CarbohydrTB.Text.Trim() != "" && ProteinTB.Text.Trim() != "" && densityTB.Text.Trim() != "")
                {
                    Product productToSave = product;

                    var selectedProduct = db.Products.Where(p => p.Id == product.Id).ToList<Product>()[0];
                    selectedProduct.Name = titleTB.Text;
                    selectedProduct.Description = descriptionTB.Text;
                    selectedProduct.Kcal = double.Parse(CaloriesTB.Text);
                    selectedProduct.Ffat = double.Parse(FatTB.Text);
                    selectedProduct.Carbohydrate = double.Parse(CarbohydrTB.Text);
                    selectedProduct.Protein = double.Parse(ProteinTB.Text);
                    selectedProduct.Density = double.Parse(densityTB.Text);
                    selectedProduct.IsAlergic = YesRB.Checked;

                    db.SaveChanges();
                    this.Close();
                }
            }
        }

    }
}
