using Guna.UI2.WinForms;
using Mockup.Forms.AddForms;
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
    public partial class CaloriesValueProductForm : Form
    {
        public bool isProduct = true;
        bool dopinfo = false; // show more info about dish components
        List<Product> items = new List<Product>(); // list Products
        int index = 0;


        const double TOTALCALORIES = 2000;
        const double TOTALPROTEIN = 160;
        const double TOTALFAT = 80;
        const double TOTALCARBOHYDRATES = 320;


        double caloriesPerc;
        double fatPerc;
        double carbPerc;
        double proteinsPerc;
        Themes.ThemeInfo theme = null;
        public CaloriesValueProductForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            trackBar.FillColor = theme.progressBarFill.Value;
            trackBar.ThumbColor = theme.progressBarValue1.Value;

            ClearProgressBar();
            productListBox.DisplayMember = "Name";
            loadItems();
            guna2GroupBox1.Text = "Продукт";
        }
        private delegate void AddItemToPLBDelegate(object item);
        private void AddItemToPLB(object item)
        {
            Product product = item as Product;
            productListBox.Items.Add(product);
        }

        private async void loadItems()
        {
            await Task.Run(() =>
            {
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        items = context.Products.ToList<Product>();
                        foreach (Product product in items)
                        {
                            productListBox.BeginInvoke(new AddItemToPLBDelegate(AddItemToPLB), product);
                        }
                        Program.parent.progressEnd = true;
                    }
                    catch
                    {
                        loadItems();
                    }
                }
            });
            if (productListBox.Items.Count > 0)
                productListBox.SelectedIndex = index;
        }
        private void ClearProgressBar()
        {
            allergicLabel.Visible = false;
            trackBar.Value = 100;
            weightTB.Text = "100";
            CaloriesPB.Value = 0;
            proteinsTB.Value = 0;
            fatTB.Value = 0;
            hydroTB.Value = 0;
            label5.Text = "0 ккал";
            label8.Text = "0 г";
            label13.Text = "0 г";
            label18.Text = "0 г";
            caloriesP.Text = "      %";
            proteinsP.Text = "      %";
            hydroP.Text = "      %";
            fatP.Text = "      %";
            label16.Text = $"Макс : {TOTALCALORIES}";
            label6.Text = $"Макс : {TOTALPROTEIN}";
            label10.Text = $"Макс : {TOTALFAT}";
            label15.Text = $"Макс : {TOTALCARBOHYDRATES}";
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productListBox.SelectedItem != null)
            {
                try
                {
                    selectItem();
                }
                catch
                {
                    // MessageBox.Show(ex.Message);
                }
            }
        }
        private void selectItem() // listbox1 selected item changed
        {
            if (weightTB.Text != "")
            {
                productTitle.Text = (productListBox.SelectedItem as Product).Name.ToString();

                Product selectedItem = productListBox.SelectedItem as Product;

                label5.Text = $"{Math.Round((selectedItem.Kcal * (double.Parse(weightTB.Text) / 100)), 2)} Ккал";
                label8.Text = $"{Math.Round((selectedItem.Protein * (double.Parse(weightTB.Text) / 100)), 2)} г";
                label13.Text = $"{Math.Round((selectedItem.Ffat * (double.Parse(weightTB.Text) / 100)), 2)} г";
                label18.Text = $"{Math.Round((selectedItem.Carbohydrate * (double.Parse(weightTB.Text) / 100)), 2)} г";

                caloriesPerc = (selectedItem.Kcal / TOTALCALORIES * 100) * (double.Parse(weightTB.Text) / 100);
                proteinsPerc = (selectedItem.Protein / TOTALPROTEIN * 100) * (double.Parse(weightTB.Text) / 100);
                fatPerc = (selectedItem.Ffat / TOTALFAT * 100) * (double.Parse(weightTB.Text) / 100);
                carbPerc = (selectedItem.Carbohydrate / TOTALCARBOHYDRATES * 100) * (double.Parse(weightTB.Text) / 100);


                CaloriesPB.Value = ((int)caloriesPerc > 100) ? 100 : (int)caloriesPerc;
                proteinsTB.Value = ((int)proteinsPerc > 100) ? 100 : (int)proteinsPerc;
                fatTB.Value = ((int)fatPerc > 100) ? 100 : (int)fatPerc;
                hydroTB.Value = ((int)carbPerc > 100) ? 100 : (int)carbPerc;

                caloriesP.Text = Math.Round(caloriesPerc, 2).ToString() + " %";
                proteinsP.Text = Math.Round(proteinsPerc, 2).ToString() + " %";
                fatP.Text = Math.Round(fatPerc, 2).ToString() + " %";
                hydroP.Text = Math.Round(carbPerc, 2).ToString() + " %";

                if (selectedItem.IsAlergic)
                    allergicLabel.Visible = true;
                else if (!selectedItem.IsAlergic)
                    allergicLabel.Visible = !true;

                if (selectedItem.Description != "")
                    descriptionLabel.Text = selectedItem.Description;
                else
                {
                    selectedItem.Description = "Описание отсутствует";
                }
            }
        }

        private void productListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ввод цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            //items.ForEach(str => { if (str.StartsWith(textBox_find.Text, StringComparison.CurrentCultureIgnoreCase)) listBox1.Items.Add(str); });
            items.ForEach(prod => { if ((prod as Product).Name.StartsWith(searchTB.Text, StringComparison.CurrentCultureIgnoreCase)) productListBox.Items.Add(prod); });
        }

        private void trackBar_Scroll(object sender, ScrollEventArgs e)
        {
            weightTB.Text = trackBar.Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CaloriesRedactorProductAdd form = new CaloriesRedactorProductAdd(theme);
            form.ShowDialog();
            productListBox.Items.Clear();
            loadItems();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedItem is Product)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Product prodfordel = productListBox.SelectedItem as Product;
                    db.Products.Attach(prodfordel);
                    db.Products.Remove(prodfordel);
                    db.SaveChanges();
                    var itemslb = db.Products.ToList();
                    productListBox.Items.Clear();
                    ClearProgressBar();
                    foreach (var item in itemslb)
                    {
                        productListBox.Items.Add(item);
                    }
                    productListBox.DisplayMember = "Name";
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedIndex > -1)
            {
                index = productListBox.SelectedIndex;
                CaloriesRedactorProductAdd form4 = new CaloriesRedactorProductAdd(theme, productListBox.SelectedItem as Product);

                form4.ShowDialog();



            }

            productListBox.Items.Clear();
            loadItems();
        }

        private void weightTB_TextChanged(object sender, EventArgs e)
        {
            if (productListBox.SelectedIndex != -1)
            {

                try
                {
                    selectItem();
                }
                catch
                {
                    // MessageBox.Show(ex.Message);
                }
            }
        }

        private void weightTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ввод цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
