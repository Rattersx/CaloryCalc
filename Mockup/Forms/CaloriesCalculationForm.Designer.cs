﻿
namespace Mockup
{
    partial class CaloriesCalculationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.modeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.activityComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.growthTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weigthTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maleRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.femaleRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calculateButton = new Guna.UI2.WinForms.Guna2Button();
            this.dailyCalorieRequirement1 = new System.Windows.Forms.Label();
            this.dailyCalorieRequirement2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.errorAll = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAll)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Режим";
            // 
            // modeComboBox
            // 
            this.modeComboBox.Animated = true;
            this.modeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.modeComboBox.BorderColor = System.Drawing.Color.Black;
            this.modeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FillColor = System.Drawing.Color.SteelBlue;
            this.modeComboBox.FocusedColor = System.Drawing.Color.PowderBlue;
            this.modeComboBox.FocusedState.BorderColor = System.Drawing.Color.PowderBlue;
            this.modeComboBox.FocusedState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.modeComboBox.FocusedState.Parent = this.modeComboBox;
            this.modeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.modeComboBox.ForeColor = System.Drawing.Color.White;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.HoverState.BorderColor = System.Drawing.Color.PowderBlue;
            this.modeComboBox.HoverState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.modeComboBox.HoverState.Parent = this.modeComboBox;
            this.modeComboBox.ItemHeight = 30;
            this.modeComboBox.Items.AddRange(new object[] {
            "Сброс веса",
            "Поддержание",
            "Набор веса"});
            this.modeComboBox.ItemsAppearance.Parent = this.modeComboBox;
            this.modeComboBox.Location = new System.Drawing.Point(27, 76);
            this.modeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.ShadowDecoration.Parent = this.modeComboBox;
            this.modeComboBox.Size = new System.Drawing.Size(380, 36);
            this.modeComboBox.TabIndex = 1;
            // 
            // activityComboBox
            // 
            this.activityComboBox.Animated = true;
            this.activityComboBox.BackColor = System.Drawing.Color.Transparent;
            this.activityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.activityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityComboBox.FocusedColor = System.Drawing.Color.PowderBlue;
            this.activityComboBox.FocusedState.BorderColor = System.Drawing.Color.PowderBlue;
            this.activityComboBox.FocusedState.FillColor = System.Drawing.Color.White;
            this.activityComboBox.FocusedState.Parent = this.activityComboBox;
            this.activityComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.activityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.HoverState.BorderColor = System.Drawing.Color.PowderBlue;
            this.activityComboBox.HoverState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.activityComboBox.HoverState.Parent = this.activityComboBox;
            this.activityComboBox.ItemHeight = 30;
            this.activityComboBox.Items.AddRange(new object[] {
            "Минимальный (никаких физических нагрузок)",
            "Низкий (физические нагрузки 1-3 раза в неделю)",
            "Средний (физические нагрузки 3-5 раза в неделю)",
            "Высокий (ежедневные физические нагрузки)",
            "Очень высокий (физические нагрузки по несколько раз в день)"});
            this.activityComboBox.ItemsAppearance.Parent = this.activityComboBox;
            this.activityComboBox.Location = new System.Drawing.Point(587, 76);
            this.activityComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.ShadowDecoration.Parent = this.activityComboBox;
            this.activityComboBox.Size = new System.Drawing.Size(583, 36);
            this.activityComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Активность";
            // 
            // growthTextBox
            // 
            this.growthTextBox.Animated = true;
            this.growthTextBox.BorderColor = System.Drawing.Color.Black;
            this.growthTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.growthTextBox.DefaultText = "";
            this.growthTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.growthTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.growthTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.growthTextBox.DisabledState.Parent = this.growthTextBox;
            this.growthTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.growthTextBox.FillColor = System.Drawing.Color.LightSkyBlue;
            this.growthTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.growthTextBox.FocusedState.Parent = this.growthTextBox;
            this.growthTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.growthTextBox.HoverState.Parent = this.growthTextBox;
            this.growthTextBox.Location = new System.Drawing.Point(29, 201);
            this.growthTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.growthTextBox.Name = "growthTextBox";
            this.growthTextBox.PasswordChar = '\0';
            this.growthTextBox.PlaceholderText = "";
            this.growthTextBox.SelectedText = "";
            this.growthTextBox.ShadowDecoration.Parent = this.growthTextBox;
            this.growthTextBox.Size = new System.Drawing.Size(200, 39);
            this.growthTextBox.TabIndex = 4;
            this.growthTextBox.TextChanged += new System.EventHandler(this.growthTextBox_TextChanged);
            this.growthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.growthTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рост";
            // 
            // weigthTextBox
            // 
            this.weigthTextBox.Animated = true;
            this.weigthTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weigthTextBox.DefaultText = "";
            this.weigthTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.weigthTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.weigthTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weigthTextBox.DisabledState.Parent = this.weigthTextBox;
            this.weigthTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weigthTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weigthTextBox.FocusedState.Parent = this.weigthTextBox;
            this.weigthTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weigthTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.weigthTextBox.HoverState.Parent = this.weigthTextBox;
            this.weigthTextBox.Location = new System.Drawing.Point(504, 201);
            this.weigthTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.weigthTextBox.Name = "weigthTextBox";
            this.weigthTextBox.PasswordChar = '\0';
            this.weigthTextBox.PlaceholderText = "";
            this.weigthTextBox.SelectedText = "";
            this.weigthTextBox.ShadowDecoration.Parent = this.weigthTextBox;
            this.weigthTextBox.Size = new System.Drawing.Size(200, 39);
            this.weigthTextBox.TabIndex = 6;
            this.weigthTextBox.TextChanged += new System.EventHandler(this.weigthTextBox_TextChanged);
            this.weigthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weigthTextBox_KeyPress);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Animated = true;
            this.ageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTextBox.DefaultText = "";
            this.ageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTextBox.DisabledState.Parent = this.ageTextBox;
            this.ageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTextBox.FocusedState.Parent = this.ageTextBox;
            this.ageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTextBox.HoverState.Parent = this.ageTextBox;
            this.ageTextBox.Location = new System.Drawing.Point(971, 201);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.PasswordChar = '\0';
            this.ageTextBox.PlaceholderText = "";
            this.ageTextBox.SelectedText = "";
            this.ageTextBox.ShadowDecoration.Parent = this.ageTextBox;
            this.ageTextBox.Size = new System.Drawing.Size(200, 39);
            this.ageTextBox.TabIndex = 7;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(972, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пол";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Animated = true;
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maleRadioButton.CheckedState.BorderThickness = 0;
            this.maleRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maleRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.maleRadioButton.CheckedState.InnerOffset = -4;
            this.maleRadioButton.Location = new System.Drawing.Point(496, 27);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(88, 21);
            this.maleRadioButton.TabIndex = 11;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Мужчина";
            this.maleRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.maleRadioButton.UncheckedState.BorderThickness = 2;
            this.maleRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.maleRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Animated = true;
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.femaleRadioButton.CheckedState.BorderThickness = 0;
            this.femaleRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.femaleRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.femaleRadioButton.CheckedState.InnerOffset = -4;
            this.femaleRadioButton.Location = new System.Drawing.Point(621, 27);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(93, 21);
            this.femaleRadioButton.TabIndex = 12;
            this.femaleRadioButton.Text = "Женщина";
            this.femaleRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.femaleRadioButton.UncheckedState.BorderThickness = 2;
            this.femaleRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.femaleRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(24, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(614, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cуточная норма калорий по формуле Миффлина - Сан Жеора без учета активности (ккал" +
    ")";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 667);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(611, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cуточная норма калорий по формуле Миффлина - Сан Жеора  с учетом активности (ккал" +
    ")";
            // 
            // calculateButton
            // 
            this.calculateButton.Animated = true;
            this.calculateButton.BackColor = System.Drawing.Color.Transparent;
            this.calculateButton.BorderRadius = 4;
            this.calculateButton.CheckedState.Parent = this.calculateButton;
            this.calculateButton.CustomImages.Parent = this.calculateButton;
            this.calculateButton.FillColor = System.Drawing.Color.LightSteelBlue;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.HoverState.Parent = this.calculateButton;
            this.calculateButton.Location = new System.Drawing.Point(935, 625);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calculateButton.ShadowDecoration.Enabled = true;
            this.calculateButton.ShadowDecoration.Parent = this.calculateButton;
            this.calculateButton.Size = new System.Drawing.Size(200, 46);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Расcчитать";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // dailyCalorieRequirement1
            // 
            this.dailyCalorieRequirement1.AutoSize = true;
            this.dailyCalorieRequirement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dailyCalorieRequirement1.Location = new System.Drawing.Point(24, 625);
            this.dailyCalorieRequirement1.Name = "dailyCalorieRequirement1";
            this.dailyCalorieRequirement1.Size = new System.Drawing.Size(30, 31);
            this.dailyCalorieRequirement1.TabIndex = 16;
            this.dailyCalorieRequirement1.Text = "0";
            // 
            // dailyCalorieRequirement2
            // 
            this.dailyCalorieRequirement2.AutoSize = true;
            this.dailyCalorieRequirement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dailyCalorieRequirement2.Location = new System.Drawing.Point(24, 697);
            this.dailyCalorieRequirement2.Name = "dailyCalorieRequirement2";
            this.dailyCalorieRequirement2.Size = new System.Drawing.Size(30, 31);
            this.dailyCalorieRequirement2.TabIndex = 17;
            this.dailyCalorieRequirement2.Text = "0";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.Controls.Add(this.femaleRadioButton);
            this.guna2GradientPanel1.Controls.Add(this.maleRadioButton);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, 390);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1265, 60);
            this.guna2GradientPanel1.TabIndex = 18;
            // 
            // errorAll
            // 
            this.errorAll.ContainerControl = this;
            // 
            // CaloriesCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 804);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dailyCalorieRequirement2);
            this.Controls.Add(this.dailyCalorieRequirement1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.weigthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.growthTextBox);
            this.Controls.Add(this.activityComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CaloriesCalculationForm";
            this.Text = "n";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox modeComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox activityComboBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox growthTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox weigthTextBox;
        private Guna.UI2.WinForms.Guna2TextBox ageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2RadioButton maleRadioButton;
        private Guna.UI2.WinForms.Guna2RadioButton femaleRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button calculateButton;
        private System.Windows.Forms.Label dailyCalorieRequirement1;
        private System.Windows.Forms.Label dailyCalorieRequirement2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.ErrorProvider errorAll;
    }
}

