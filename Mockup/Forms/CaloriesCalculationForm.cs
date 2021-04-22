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
            Commands.ApplyTheme(this, theme);
            activityComboBox.DropDownStyle = ComboBoxStyle.DropDownList; //запрещаем на ввод значения в comboBox
            modeComboBox.SelectedIndex = 0;
            activityComboBox.SelectedIndex = 0;
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            System.Threading.Timer t = new System.Threading.Timer(CheckedTextBox, null, 0, 400);
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
            if (!Char.IsDigit(number) && number != 8) // ввод цифры и клавиша BackSpace
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<Guna2TextBox>().Any(t => string.IsNullOrWhiteSpace(t.Text)) && Controls.OfType<Guna2TextBox>().All(t => t.BackColor == Color.GreenYellow)) //проверка на пустоту строк и элементов, если не пустые идем дальше
                return;
            else
            {
                if (maleRadioButton.Checked)
                {
                    dailyCalorieRequirement1.Text = FormulaGeoraMaleSimple().ToString();
                    dailyCalorieRequirement2.Text = FormulaGeoraMale().ToString();
                }
                else
                {
                    dailyCalorieRequirement1.Text = FormulaGeoraFemaleSimple().ToString();
                    dailyCalorieRequirement2.Text = FormulaGeoraFemale().ToString();
                }
            }
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

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate(ageTextBox, 10, 120);
        }

        private void Validate(Guna2TextBox textBox, int down, int up)
        {
            //if (Controls.OfType<TextBox>().Any(t => !string.IsNullOrEmpty(t.Text)))
            if (textBox.Text != "")
            {
                double buff = Double.Parse(textBox.Text);
                if (buff >= down && buff <= up)
                {
                    textBox.BackColor = Color.GreenYellow;
                    errorAll.Clear();
                }
                else
                {
                    textBox.BackColor = Color.Red;
                    errorAll.SetError(textBox, $"От {down} до {up}");
                }
            }
            else
            {
                textBox.BackColor = default;
                errorAll.Clear();
            }

        }

        private void weigthTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate(weigthTextBox, 10, 120);
        }

        private void growthTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate(growthTextBox, 10, 120);
        }
        private void CheckedTextBox(Object obj)
        {
            if (Controls.OfType<TextBox>().Any(t => !string.IsNullOrEmpty(t.Text)) && Controls.OfType<TextBox>().All(t => t.BackColor == Color.GreenYellow))
            {
                if (maleRadioButton.Checked)
                {
                    dailyCalorieRequirement1.Text = FormulaGeoraMaleSimple().ToString();
                    dailyCalorieRequirement2.Text = FormulaGeoraMale().ToString();
                }
                else
                {
                    dailyCalorieRequirement1.Text = FormulaGeoraFemaleSimple().ToString();
                    dailyCalorieRequirement2.Text = FormulaGeoraFemale().ToString();
                }
            }
        }

    }
}
