using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Mockup
{
    public partial class CaloriesCalculationForm : Form
    {
        Themes.ThemeInfo theme = null;
        private double[] A = { 1.2, 1.375, 1.55, 1.7, 1.9 };  //массив со значениями активности
        private double[] R = { 0.8, 1.0, 1.19 };  //массив со значениями режима
        public CaloriesCalculationForm(Themes.ThemeInfo _theme)
        {
            InitializeComponent();

            theme = _theme;
            Commands.ApplyTheme(this, null, theme);
            activityComboBox.DropDownStyle = ComboBoxStyle.DropDownList; //запрещаем на ввод значения в comboBox
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.SelectedIndex = 0;
            activityComboBox.SelectedIndex = 0;
            //System.Threading.Timer t = new System.Threading.Timer(CheckedTextBox, null, 0, 400);
            Timer timer = new Timer();
            timer.Interval = 400;
            timer.Tick += CheckedTextBox;
            timer.Start();
        }


        private double FormulaGeoraMale()   //метод подсчета формулы (+ Активность) для мужчин
        {
            double rezult = 0;
            if (activityComboBox.SelectedIndex != -1)
            {
                rezult = FormulaGeoraMaleSimple() * A[activityComboBox.SelectedIndex];  // считаем по простой формуле + значение активности
            }
            return rezult;
        }

        private double FormulaGeoraMaleSimple() //метод подсчета простой формулы для мужчин с режимом
        {
            double rezult = 88.362 + (13.397 * double.Parse(weigthTextBox.Text)) + (4.799 * double.Parse(growthTextBox.Text)) - (5.677 * double.Parse(ageTextBox.Text)) * R[modeComboBox.SelectedIndex];
            return rezult;
        }

        private double FormulaGeoraFemale()     //метод подсчета формулы (+ Активность) для женщин
        {
            double rezult = 0;
            if (activityComboBox.SelectedIndex != -1)
            {
                rezult = FormulaGeoraFemaleSimple() * A[activityComboBox.SelectedIndex]; // считаем по простой формуле + значение активности
            }
            return rezult;
        }

        private double FormulaGeoraFemaleSimple() // метод подсчета простой формулы для женщин с режимом
        {
            double rezult = 447.593 + (9.247 * double.Parse(weigthTextBox.Text)) + (3.098 * double.Parse(growthTextBox.Text)) - (4.330 * double.Parse(ageTextBox.Text)) * R[modeComboBox.SelectedIndex];
            return rezult;
        }

        //метод валидации, если значение не в приделах значений которые указаны в условии, выводиться ошибка
        private void Validate(Guna2TextBox textBox, double down, double up, ErrorProvider error)
        {
            
            if (textBox.Text != "")
            {
                double buff = Double.Parse(textBox.Text);
                if (buff >= down && buff <= up)
                {
                    textBox.FillColor = Color.GreenYellow;
                    error.Clear();
                }
                else
                {
                    textBox.FillColor = Color.Red;
                    error.SetError(textBox, $"От {down} до {up}");
                }
            }
            else
            {
                textBox.FillColor = theme.TextBoxFill.Value;
                error.Clear();
            }

        }

        //метод вывода посчитаных калорий при правильном заполнении TextBox, то есть если все TextBox прошли валидацию
        private void CheckedTextBox(Object obj, EventArgs e)
        {
            if (Controls.OfType<Guna2TextBox>().All(t => !string.IsNullOrEmpty(t.Text)) && Controls.OfType<Guna2TextBox>().All(a=>a.FillColor == Color.GreenYellow))//проверка на пустоту строк и элементов и на валидацию, если все ок, идем дальше
            {
                if (maleRadioButton.Checked)
                {
                    dailyCalorieRequirement1.Text = Convert.ToInt32(FormulaGeoraMaleSimple()).ToString();
                    dailyCalorieRequirement2.Text = Convert.ToInt32(FormulaGeoraMale()).ToString();
                }
                else
                {
                    dailyCalorieRequirement1.Text = Convert.ToInt32(FormulaGeoraFemaleSimple()).ToString();
                    dailyCalorieRequirement2.Text = Convert.ToInt32(FormulaGeoraFemale()).ToString();
                }
            }
        }

        //проверка на валидацию каждого TextBox
        private void growthTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate(growthTextBox, 100, 250, errorGrowth);
        }

        private void weigthTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate(weigthTextBox, 20, 250, errorWeight);
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate(ageTextBox, 10, 120, errorAge);
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<Guna2TextBox>().All(t => !string.IsNullOrEmpty(t.Text)) && Controls.OfType<Guna2TextBox>().All(a => a.FillColor == Color.GreenYellow)) //проверка на пустоту строк и элементов и на валидацию, если все ок, идем дальше
            {
                if (maleRadioButton.Checked)
                {
                    dailyCalorieRequirement1.Text = Convert.ToInt32(FormulaGeoraMaleSimple()).ToString();
                    dailyCalorieRequirement2.Text = Convert.ToInt32(FormulaGeoraMale()).ToString();
                }
                else
                {
                    dailyCalorieRequirement1.Text = Convert.ToInt32(FormulaGeoraFemaleSimple()).ToString();
                    dailyCalorieRequirement2.Text = Convert.ToInt32(FormulaGeoraFemale()).ToString();
                }
            }
            else return;
        }

        private void growthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ввод цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void weigthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // ввод цифры, клавиша BackSpace и то4ка
            {
                e.Handled = true;
            }
        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ввод цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
