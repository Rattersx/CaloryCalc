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
        public Dish selectedItem;
        bool isAdd = false;
        public CaloriesRedactorDish_Edit(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            AnimateWindow.SetAnimateWindow(this);
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
            bunifuCustomLabel1.Text = "Добавить";
            Commands.ApplyTheme(this, theme);
            if (theme.black)
            {
                guna2ImageButton1.Image = blackList.Images[0];
                guna2ImageButton2.Image = blackList.Images[1];
            }
            else
            {
                guna2ImageButton1.Image = blueList.Images[0];
                guna2ImageButton2.Image = blueList.Images[1];
            }
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";
            LoadAllProducts();
            guna2ComboBox1.SelectedIndex = 0;
            isAdd = true;

        }
        public CaloriesRedactorDish_Edit(Themes.ThemeInfo _theme, Dish selectedDish)
        {
            InitializeComponent();
            theme = _theme;
            AnimateWindow.SetAnimateWindow(this);
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
            bunifuCustomLabel1.Text = "Изменить";
            Commands.ApplyTheme(this, theme);
            if (theme.black)
            {
                guna2ImageButton1.Image = blackList.Images[0];
                guna2ImageButton2.Image = blackList.Images[1];
            }
            else
            {
                guna2ImageButton1.Image = blueList.Images[0];
                guna2ImageButton2.Image = blueList.Images[1];
            }
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";
            LoadAllProducts();
            guna2ComboBox1.SelectedIndex = 0;
            selectedItem = selectedDish;

            dishInfo(selectedDish);
            listBox2.Items.Clear();
            LoadThisProducts(selectedDish);
            //LoadAllProducts();
            isAdd = false;
        }
        void dishInfo(Dish dish)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var selectedDish = context.Dishes.Where(d => d.Id == dish.Id).ToList<Dish>();


                titleTB.Text = selectedDish[0].Name;
                guna2TextBox1.Text = selectedDish[0].Description;
            }
        }
        private delegate void AddToListDelegate(object product);
        private delegate void AddToListValueDelegate(double value);
        private delegate void AddToListMeasDelegate(string type);
        private void AddToAllProductList(object _product)
        {
            Product product = _product as Product;
            listBox1.Items.Add(product);
        }
        private void AddToThisProductList(object _product)
        {
            Product product = _product as Product;
            listBox2.Items.Add(product);
        }
        private void AddProductValueList(double value)
        {
            listBox3.Items.Add(value);
        }
        private void AddProductMeasList(string type)
        {
            listBox4.Items.Add(type);
        }


        private void LoadThisProducts(object _dish)
        {
            Task.Run(() =>
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Dish dish = _dish as Dish;
                    var selectedDishProduct = db.DishItems.Where(d => d.DishId == dish.Id);
                    var DishProducts = selectedDishProduct.Select(i => i.Product).ToList<Product>();
                    var DishProductValue = selectedDishProduct.Select(i => i.Value).ToList<double>();
                    var DishProductMeas = selectedDishProduct.Select(i => i.MeasurementUnitId).ToList<int>();
                    List<string> DishMeasurements = new List<string>();

                    //ToList().Select(n => n.to)
                    foreach (var meas in DishProductMeas)
                    {
                        DishMeasurements.AddRange(db.MeasurementUnits.Where(i => i.Id == meas).Select(n => n.Title.ToString()).ToList());

                    }
                    DishMeasurements.Reverse();

                    //DishMeasurements.Add(meas => db.MeasurementUnits.Where(i => i.Id = meas).Select(n => n.Title).);
                    //DishMeasurements.ForEach(item => item.Add(meas=> db.MeasurementUnits.Where(i => i.Id = meas).Select(n => n.Title));

                    foreach (Product product in DishProducts)
                    {
                        listBox2.BeginInvoke(new AddToListDelegate(AddToThisProductList), product);
                    }

                    DishProductValue.ForEach(value => listBox3.BeginInvoke(new AddToListValueDelegate(AddProductValueList), value));

                    DishMeasurements.ForEach(meas => listBox4.BeginInvoke(new AddToListMeasDelegate(AddProductMeasList), meas));
                }
            });
        }
        private void LoadAllProducts()
        {
            Task.Run(() =>
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var products = db.Products.ToList<Product>();
                    foreach (Product item in products)
                    {
                        listBox1.BeginInvoke(new AddToListDelegate(AddToAllProductList), item);
                    }
                }
            });
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

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text != "" && listBox1.SelectedIndex > -1 && (guna2ComboBox1.Text == "Грамм" || guna2ComboBox1.Text == "Мл") && (int.Parse(guna2TextBox2.Text) > 0 && int.Parse(guna2TextBox2.Text) < 5000))
            {
                try
                {
                    listBox2.Items.Add(listBox1.SelectedItem as Product);
                    listBox3.Items.Add(Convert.ToDouble(guna2TextBox2.Text));
                    listBox4.Items.Add(guna2ComboBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Заполните поля, количество и тип измерения и выберите продукт.");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox3.Items.RemoveAt(listBox2.SelectedIndex);
                listBox4.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                try
                {
                    if (titleTB.Text != "" && listBox2.Items.Count > -1)
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            Dish newDish = new Dish
                            {
                                Name = titleTB.Text,
                                Description = guna2TextBox1.Text,
                            };
                            db.Dishes.ToList().ForEach(i =>
                            {
                                if (i.Name == newDish.Name)
                                    throw new Exception("Такое блюдо уже есть в списке");
                            });
                            db.Dishes.Add(newDish); db.SaveChanges();
                            for (int i = 0; i < listBox2.Items.Count; i++)
                            {
                                MeasurementUnit newMU = new MeasurementUnit();
                                if (listBox4.Items[i].ToString() == "Грамм")
                                {
                                    newMU.Title = "Грамм";
                                    newMU.InGramm = (double)listBox3.Items[i];
                                }
                                else if (listBox4.Items[i].ToString() == "Мл")
                                {
                                    newMU.Title = "Мл";
                                    newMU.Volume = (double)listBox3.Items[i];
                                }
                                db.MeasurementUnits.Add(newMU);
                                db.SaveChanges();
                                DishItem newDishitem = new DishItem
                                {
                                    ProductId = (listBox2.Items[i] as Product).Id,
                                    DishId = newDish.Id,
                                    Value = 0,
                                    MeasurementUnitId = newMU.Id,
                                };
                                db.DishItems.Add(newDishitem);
                                db.SaveChanges();
                            }
                        }
                        MessageBox.Show("Блюдо добавлено!");
                        Close();
                    }
                    else MessageBox.Show("Введите название блюда!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (titleTB.Text != "" && listBox2.Items.Count > -1)
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var dish = db.Dishes.Where(d => d.Id == selectedItem.Id).ToList<Dish>()[0];
                            dish.Name = titleTB.Text;
                            dish.Description = guna2TextBox1.Text;

                            db.SaveChanges();


                            for (int i = 0; i < listBox2.Items.Count; i++)
                            {
                                MeasurementUnit newMU = new MeasurementUnit();
                                if (listBox4.Items[i].ToString() == "Грамм")
                                {
                                    newMU.Title = "Грамм";
                                    newMU.InGramm = (double)listBox3.Items[i];
                                }
                                else if (listBox4.Items[i].ToString() == "Мл")
                                {
                                    newMU.Title = "Мл";
                                    newMU.Volume = (double)listBox3.Items[i];
                                }

                                db.MeasurementUnits.Add(newMU);
                                db.SaveChanges();

                                DishItem newDishitem = new DishItem
                                {
                                    ProductId = (listBox2.Items[i] as Product).Id,
                                    DishId = dish.Id,
                                    Value = 0,
                                    MeasurementUnitId = newMU.Id,
                                };
                                db.DishItems.Add(newDishitem);
                                db.SaveChanges();
                            }
                        }
                        MessageBox.Show("Блюдо добавлено!");
                    }
                    else MessageBox.Show("Введите название блюда!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void titleTB_TextChanged(object sender, EventArgs e)
        {
            if (titleTB.Text != "")
                AcceptButton.Enabled = true;
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ввод цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
