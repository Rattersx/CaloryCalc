using Mockup.Forms.SecondLevelForms.AddEditForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Mockup.Forms.SecondLevelForms
{
    public partial class CaloriesValueDishForm : Form
    {
        bool dopinfo = false; // show more info about dish components
        List<Dish> items = new List<Dish>(); // list Products        

        const double TOTALCALORIES = 2000;
        const double TOTALPROTEIN = 160;
        const double TOTALFAT = 80;
        const double TOTALCARBOHYDRATES = 320;


        double caloriesPerc;
        double fatPerc;
        double carbPerc;
        double proteinsPerc;

        bool productListExpand = false;
        Themes.ThemeInfo theme = null;
        public CaloriesValueDishForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            ProductContainer.Width = 0;

            ApplicationContext context = new ApplicationContext();

            ClearProgressBar();
            dishListBox.DisplayMember = "Name";
            loadItems();
            label1.Text = "Блюдо";
        }
        private void ClearProgressBar()
        {
            trackBar.Value = 100;
            weightTB.Text = "100";
            CaloriesPB.Value = 0;
            guna2ProgressBar1.Value = 0;
            guna2ProgressBar2.Value = 0;
            guna2ProgressBar3.Value = 0;
            label5.Text = "0 г";
            label8.Text = "0 г";
            label13.Text = "0 г";
            label18.Text = "0 г";
            label12.Text = "      %";
            label7.Text = "      %";
            label11.Text = "      %";
            label17.Text = "      %";
            label16.Text = $"Макс : {TOTALCALORIES}";
            label6.Text = $"Макс : {TOTALPROTEIN}";
            label10.Text = $"Макс : {TOTALFAT}";
            label15.Text = $"Макс : {TOTALCARBOHYDRATES}";
        }
        private delegate void AddItemToPLBDelegate(object item);
        private void AddItemToPLB(object item)
        {
            Dish product = item as Dish;
            dishListBox.Items.Add(product);
        }

        private void loadItems()
        {
            Task.Run(() =>
            {
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        items = context.Dishes.ToList<Dish>();
                        foreach (Dish product in items)
                        {
                            productListBox.BeginInvoke(new AddItemToPLBDelegate(AddItemToPLB), product);
                        }
                    }
                    catch (Exception ex)
                    {
                        loadItems();
                    }
                }
                Program.parent.progressEnd = true;
            });
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
                try
                {
                    selectItem();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
            }            
        }
        private void selectItem() // listbox1 selected item changed
        {
            productListBox.Items.Clear();
            gramsListBox.Items.Clear();
            if (weightTB.Text != "")
            {
                label1.Text = (dishListBox.SelectedItem as Dish).Name.ToString();
                using (ApplicationContext db = new ApplicationContext())
                {
                    double caloriesPerc2 = 0; double proteinsPerc2 = 0; double fatPerc2 = 0; double carbPerc2 = 0;
                    double caloriesAll = 0; double proteinsAll = 0; double fatAll = 0; double carbAll = 0;
                   //
                    int selectedDishId = (dishListBox.SelectedItem as Dish).Id;
                    var selectedDishProduct = db.DishItems.Include(t=>t.Product).Where(d => d.DishId == selectedDishId);
                    var DishProducts = selectedDishProduct.Select(i => i.Product).ToList();
                    var DishProducts2 = selectedDishProduct.Select(i => i.MeasurementUnit).ToList();
                    productListBox.DisplayMember = "Name";
                    for (int i = 0; i < DishProducts.Count; i++)
                    {
                        productListBox.Items.Add(DishProducts[i]);
                        if (DishProducts2[i].Title == "Грамм")
                        {
                            gramsListBox.Items.Add($"{DishProducts2[i].InGramm} { DishProducts2[i].Title}");
                        }
                        else gramsListBox.Items.Add($"{DishProducts2[i].Volume} {DishProducts2[i].Title}");
                        caloriesAll = caloriesAll + DishProducts[i].Kcal;
                        proteinsAll = proteinsAll + DishProducts[i].Protein;
                        fatAll = fatAll + DishProducts[i].Ffat;
                        carbAll = carbAll + DishProducts[i].Carbohydrate;
                    }

                    label1.Text = $"{Math.Round((caloriesAll * (double.Parse(weightTB.Text) / 100)), 2)} Ккал";
                    label2.Text = $"{Math.Round((proteinsAll * (double.Parse(weightTB.Text) / 100)), 2)} г";
                    label3.Text = $"{Math.Round((fatAll * (double.Parse(weightTB.Text) / 100)), 2)} г";
                    label4.Text = $"{Math.Round((carbAll * (double.Parse(weightTB.Text) / 100)), 2)} г";

                    caloriesPerc2 = (caloriesAll / TOTALCALORIES * 100) * (double.Parse(weightTB.Text) / 100);
                    proteinsPerc2 = (proteinsAll / TOTALPROTEIN * 100) * (double.Parse(weightTB.Text) / 100);
                    fatPerc2 = (fatAll / TOTALFAT * 100) * (double.Parse(weightTB.Text) / 100);
                    carbPerc2 = (carbAll / TOTALCARBOHYDRATES * 100) * (double.Parse(weightTB.Text) / 100);

                    CaloriesPB.Value = ((int)caloriesPerc2 > 100) ? 100 : (int)caloriesPerc2;
                    guna2ProgressBar1.Value = ((int)proteinsPerc2 > 100) ? 100 : (int)proteinsPerc2;
                    guna2ProgressBar2.Value = ((int)fatPerc2 > 100) ? 100 : (int)fatPerc2;
                    guna2ProgressBar3.Value = ((int)carbPerc2 > 100) ? 100 : (int)carbPerc2;

                    label5.Text = Math.Round(caloriesPerc2, 2).ToString() + " %";
                    label6.Text = Math.Round(proteinsPerc2, 2).ToString() + " %";
                    label7.Text = Math.Round(fatPerc2, 2).ToString() + " %";
                    label8.Text = Math.Round(carbPerc2, 2).ToString() + " %";

                    if ((dishListBox.SelectedItem as Dish).Description != "")
                        label21.Text = (dishListBox.SelectedItem as Dish).Description;
                    else
                    {
                        (dishListBox.SelectedItem as Dish).Description = "Описание отсутствует";
                    }
                }
            }
        }

        private void weightTB_TextChanged(object sender, EventArgs e)
        {
            if (dishListBox.Items.Count > 0)
            {
                if (dishListBox.SelectedIndex > -1)
                {
                    if (Convert.ToInt32(weightTB.Text) > 0 && Convert.ToInt32(weightTB.Text) < 1001)
                        selectItem();
                }
                else if (dishListBox.SelectedIndex < 0)
                {
                    ClearProgressBar();
                }
            }
            else
            {
                ClearProgressBar();
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dishListBox.Items.Clear();
            //items.ForEach(str => { if (str.StartsWith(textBox_find.Text, StringComparison.CurrentCultureIgnoreCase)) listBox1.Items.Add(str); });
            items.ForEach(dish => { if ((dish as Dish).Name.StartsWith(guna2TextBox1.Text, StringComparison.CurrentCultureIgnoreCase)) dishListBox.Items.Add(dish); });
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productListBox.SelectedIndex > -1)
            {
                Form fc = Application.OpenForms["CaloriesValueDish_ProductInfo"];
                if (fc != null)
                    fc.Close();
                gramsListBox.SelectedIndex = productListBox.SelectedIndex;
                CaloriesValueDish_ProductInfo form2 = new  CaloriesValueDish_ProductInfo(theme, productListBox.SelectedItem as Product);
                form2.Text = $"Блюдо : {(dishListBox.SelectedItem as Dish).Name}";
                form2.Show();
            }
        }

        private void trackBar_Scroll(object sender, ScrollEventArgs e)
        {
            weightTB.Text = trackBar.Value.ToString();
        }

        private void gramsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productListBox.SelectedIndex = gramsListBox.SelectedIndex;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CaloriesRedactorDish_Edit form3 = new CaloriesRedactorDish_Edit(theme, true);
            form3.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dishListBox.SelectedIndex > -1)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Dish dishfordel = dishListBox.SelectedItem as Dish;
                    db.Dishes.Remove(dishfordel);
                    db.SaveChanges();
                    var itemsdish = db.Dishes.ToList();
                    dishListBox.Items.Clear();
                    productListBox.Items.Clear();
                    gramsListBox.Items.Clear();
                    ClearProgressBar();
                    foreach (var item in itemsdish)
                    {
                        dishListBox.Items.Add(item);
                    }
                    dishListBox.DisplayMember = "Name";
                }
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            CaloriesRedactorDish_Edit form = new CaloriesRedactorDish_Edit(theme, false);
            form.ShowDialog();
        }
    }
}
