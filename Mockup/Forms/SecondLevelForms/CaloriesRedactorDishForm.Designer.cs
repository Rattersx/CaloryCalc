
namespace Mockup.Forms.SecondLevelForms
{
    partial class CaloriesRedactorDishForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaloriesRedactorDishForm));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Container = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.proteinValueLabel = new System.Windows.Forms.Label();
            this.hydrosValueLabel = new System.Windows.Forms.Label();
            this.fatValueLabel = new System.Windows.Forms.Label();
            this.CaloriesValueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteButon = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Container.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.Animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation2;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.LightCyan;
            this.Container.Controls.Add(this.label5);
            this.Container.Controls.Add(this.proteinValueLabel);
            this.Container.Controls.Add(this.hydrosValueLabel);
            this.Container.Controls.Add(this.fatValueLabel);
            this.Container.Controls.Add(this.CaloriesValueLabel);
            this.Container.Controls.Add(this.label4);
            this.Container.Controls.Add(this.label3);
            this.Container.Controls.Add(this.label2);
            this.Container.Controls.Add(this.label1);
            this.Container.Controls.Add(this.searchTextBox);
            this.Container.Controls.Add(this.deleteButon);
            this.Container.Controls.Add(this.editButton);
            this.Container.Controls.Add(this.addButton);
            this.Container.Controls.Add(this.guna2GroupBox1);
            this.Animator.SetDecoration(this.Container, BunifuAnimatorNS.DecorationType.None);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(931, 614);
            this.Container.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 45;
            this.label5.Text = "Поиск:";
            // 
            // proteinValueLabel
            // 
            this.proteinValueLabel.AutoSize = true;
            this.Animator.SetDecoration(this.proteinValueLabel, BunifuAnimatorNS.DecorationType.None);
            this.proteinValueLabel.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.proteinValueLabel.Location = new System.Drawing.Point(566, 399);
            this.proteinValueLabel.Name = "proteinValueLabel";
            this.proteinValueLabel.Size = new System.Drawing.Size(75, 42);
            this.proteinValueLabel.TabIndex = 44;
            this.proteinValueLabel.Text = "241";
            // 
            // hydrosValueLabel
            // 
            this.hydrosValueLabel.AutoSize = true;
            this.Animator.SetDecoration(this.hydrosValueLabel, BunifuAnimatorNS.DecorationType.None);
            this.hydrosValueLabel.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.hydrosValueLabel.Location = new System.Drawing.Point(566, 329);
            this.hydrosValueLabel.Name = "hydrosValueLabel";
            this.hydrosValueLabel.Size = new System.Drawing.Size(75, 42);
            this.hydrosValueLabel.TabIndex = 43;
            this.hydrosValueLabel.Text = "241";
            // 
            // fatValueLabel
            // 
            this.fatValueLabel.AutoSize = true;
            this.Animator.SetDecoration(this.fatValueLabel, BunifuAnimatorNS.DecorationType.None);
            this.fatValueLabel.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.fatValueLabel.Location = new System.Drawing.Point(566, 262);
            this.fatValueLabel.Name = "fatValueLabel";
            this.fatValueLabel.Size = new System.Drawing.Size(75, 42);
            this.fatValueLabel.TabIndex = 42;
            this.fatValueLabel.Text = "241";
            // 
            // CaloriesValueLabel
            // 
            this.CaloriesValueLabel.AutoSize = true;
            this.Animator.SetDecoration(this.CaloriesValueLabel, BunifuAnimatorNS.DecorationType.None);
            this.CaloriesValueLabel.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.CaloriesValueLabel.Location = new System.Drawing.Point(566, 198);
            this.CaloriesValueLabel.Name = "CaloriesValueLabel";
            this.CaloriesValueLabel.Size = new System.Drawing.Size(75, 42);
            this.CaloriesValueLabel.TabIndex = 41;
            this.CaloriesValueLabel.Text = "241";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Animator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.label4.Location = new System.Drawing.Point(449, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 40;
            this.label4.Text = "Белки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.Animator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.label3.Location = new System.Drawing.Point(383, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 39;
            this.label3.Text = "Углеводов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Animator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.label2.Location = new System.Drawing.Point(435, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Жиров:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.label1.Location = new System.Drawing.Point(369, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "ККаллорий:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Animated = true;
            this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextBox.BorderColor = System.Drawing.Color.Black;
            this.searchTextBox.BorderRadius = 1;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.searchTextBox, BunifuAnimatorNS.DecorationType.None);
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.Parent = this.searchTextBox;
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FillColor = System.Drawing.Color.AliceBlue;
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.searchTextBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(242)))), ((int)(((byte)(214)))));
            this.searchTextBox.FocusedState.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.FocusedState.Parent = this.searchTextBox;
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.searchTextBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.IconLeft = global::Mockup.Properties.Resources.search_64px;
            this.searchTextBox.IconLeftSize = new System.Drawing.Size(36, 36);
            this.searchTextBox.Location = new System.Drawing.Point(30, 57);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.searchTextBox.PlaceholderText = "Поиск блюда";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(264, 36);
            this.searchTextBox.TabIndex = 36;
            // 
            // deleteButon
            // 
            this.deleteButon.BorderRadius = 5;
            this.deleteButon.CheckedState.Parent = this.deleteButon;
            this.deleteButon.CustomImages.Parent = this.deleteButon;
            this.Animator.SetDecoration(this.deleteButon, BunifuAnimatorNS.DecorationType.None);
            this.deleteButon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteButon.ForeColor = System.Drawing.Color.White;
            this.deleteButon.HoverState.Parent = this.deleteButon;
            this.deleteButon.Location = new System.Drawing.Point(733, 532);
            this.deleteButon.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButon.Name = "deleteButon";
            this.deleteButon.ShadowDecoration.Parent = this.deleteButon;
            this.deleteButon.Size = new System.Drawing.Size(173, 56);
            this.deleteButon.TabIndex = 29;
            this.deleteButon.Text = "Удалить";
            // 
            // editButton
            // 
            this.editButton.BorderRadius = 5;
            this.editButton.CheckedState.Parent = this.editButton;
            this.editButton.CustomImages.Parent = this.editButton;
            this.Animator.SetDecoration(this.editButton, BunifuAnimatorNS.DecorationType.None);
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.HoverState.Parent = this.editButton;
            this.editButton.Location = new System.Drawing.Point(733, 133);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.ShadowDecoration.Parent = this.editButton;
            this.editButton.Size = new System.Drawing.Size(173, 56);
            this.editButton.TabIndex = 28;
            this.editButton.Text = "Изменить";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BorderRadius = 5;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.Animator.SetDecoration(this.addButton, BunifuAnimatorNS.DecorationType.None);
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(733, 57);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(173, 56);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.listBox1);
            this.guna2GroupBox1.Controls.Add(this.panel22);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.PaleTurquoise;
            this.Animator.SetDecoration(this.guna2GroupBox1, BunifuAnimatorNS.DecorationType.None);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(30, 133);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(264, 362);
            this.guna2GroupBox1.TabIndex = 35;
            this.guna2GroupBox1.Text = "Блюдо";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.Animator.SetDecoration(this.listBox1, BunifuAnimatorNS.DecorationType.None);
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(0, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 322);
            this.listBox1.TabIndex = 2;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.panel22, BunifuAnimatorNS.DecorationType.None);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(264, 40);
            this.panel22.TabIndex = 1;
            this.panel22.Paint += new System.Windows.Forms.PaintEventHandler(this.panel22_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // CaloriesRedactorDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(931, 614);
            this.Controls.Add(this.Container);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaloriesRedactorDishForm";
            this.Text = "CaloriesRedactorDishForm";
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Label proteinValueLabel;
        private System.Windows.Forms.Label hydrosValueLabel;
        private System.Windows.Forms.Label fatValueLabel;
        private System.Windows.Forms.Label CaloriesValueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button deleteButon;
        private Guna.UI2.WinForms.Guna2Button editButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label5;
    }
}