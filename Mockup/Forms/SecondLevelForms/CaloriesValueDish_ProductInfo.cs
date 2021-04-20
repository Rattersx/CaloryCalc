using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup.Forms.SecondLevelForms
{
    public partial class CaloriesValueDish_ProductInfo : Form
    {
        /* Именование эллементов
        Навзвание продукта - productTitle
        Колличество продуктов - countTB
        Тип измерения - typeCB
        
        Progress Bar:

        Каллории - caloriesPB
        Белки - proteinsPB
        Жиры - fatPB
        Углеводы - hydroPB
        Вода - waterPB
        Клетчатка - cellulosePB

        Остальные эллементы, которые относятся к ProgressBar имеют аналогичные название, 
        только вместо PB в конце - соответствующее дополнение (caloriesValue, caloriesMin, caloriesP(ercent))
        */
        const double TOTALCALORIES = 2000;
        const double TOTALPROTEIN = 160;
        const double TOTALFAT = 80;
        const double TOTALCARBOHYDRATES = 320;

        double caloriesPerc;
        double fatPerc;
        double carbPerc;
        double proteinsPerc;

        Product selectedprod;

        Themes.ThemeInfo theme = null;
        public CaloriesValueDish_ProductInfo(Themes.ThemeInfo _theme, Product prod)
        {
            InitializeComponent();
            #region Design
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            panel1.BackColor = theme.MenuColor1.Value;
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
            #endregion
            alergicL.Visible = false;
            selectedprod = prod;
            caloriesMin.Text = $"Макс : {TOTALCALORIES}";
            proteinsMin.Text = $"Макс : {TOTALPROTEIN}";
            fatMin.Text = $"Макс : {TOTALFAT}";
            hydroMin.Text = $"Макс : {TOTALCARBOHYDRATES}";
            trackbar.Value = 100;
            showprogress(selectedprod);
        }
        private void showprogress(Product product) // 50% Алгоритма Михаил Л
        {
            Product selectedprod = product;
            titleLable.Text = selectedprod.Name.ToString();

            caloriesValue.Text = $"{Math.Round((selectedprod.Kcal * (Convert.ToDouble(trackbar.Value) / 100)), 2)} Ккал";
            proteinsValue.Text = $"{Math.Round((selectedprod.Protein * (Convert.ToDouble(trackbar.Value) / 100)), 2)} г";
            fatValue.Text = $"{Math.Round((selectedprod.Ffat * (Convert.ToDouble(trackbar.Value) / 100)), 2)} г";
            hydroValue.Text = $"{Math.Round((selectedprod.Carbohydrate * (Convert.ToDouble(trackbar.Value) / 100)), 2)} г";

            caloriesPerc = (selectedprod.Kcal / TOTALCALORIES * 100) * (Convert.ToDouble(trackbar.Value) / 100);
            proteinsPerc = (selectedprod.Protein / TOTALPROTEIN * 100) * (Convert.ToDouble(trackbar.Value) / 100);
            fatPerc = (selectedprod.Ffat / TOTALFAT * 100) * (Convert.ToDouble(trackbar.Value) / 100);
            carbPerc = (selectedprod.Carbohydrate / TOTALCARBOHYDRATES * 100) * (Convert.ToDouble(trackbar.Value) / 100);


            caloriesPB.Value = ((int)caloriesPerc > 100) ? 100 : (int)caloriesPerc;
            proteinsPB.Value = ((int)proteinsPerc > 100) ? 100 : (int)proteinsPerc;
            fatPB.Value = ((int)fatPerc > 100) ? 100 : (int)fatPerc;
            hydroPB.Value = ((int)carbPerc > 100) ? 100 : (int)carbPerc;

            caloriesP.Text = Math.Round(caloriesPerc, 2).ToString() + " %";
            proteinsP.Text = Math.Round(proteinsPerc, 2).ToString() + " %";
            fatP.Text = Math.Round(fatPerc, 2).ToString() + " %";
            hydroP.Text = Math.Round(carbPerc, 2).ToString() + " %";

            if (selectedprod.IsAlergic)
                alergicL.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            titleLable.ForeColor = guna2ColorTransition1.Value;
        }

        // Exit Button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaloriesValueDish_ProductInfo_Load(object sender, EventArgs e)
        {
            countTB.Text = trackbar.Value.ToString();
        }

        private void countTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ввод цифры и клавиша BackSpace ( Метод От Михаила Л )
            {
                e.Handled = true;
            }
        }

        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            countTB.Text = trackbar.Value.ToString();
            showprogress(selectedprod);
        }
    }
}
