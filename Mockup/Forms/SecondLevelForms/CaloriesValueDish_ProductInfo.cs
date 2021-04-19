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
        Themes.ThemeInfo theme = null;
        public CaloriesValueDish_ProductInfo(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            #region Design
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            panel1.BackColor = theme.MenuColor1.Value;
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
            #endregion
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
    }
}
