
namespace Mockup
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.TitlePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.expandBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Container = new System.Windows.Forms.Panel();
            this.Menu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SettingsButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.EditorButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.CalculationButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.burgerMenuBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CaloriesButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.blackIcons = new System.Windows.Forms.ImageList(this.components);
            this.blueIcons = new System.Windows.Forms.ImageList(this.components);
            this.fadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitlePanel.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.titleLabel);
            this.TitlePanel.Controls.Add(this.minimizeBtn);
            this.TitlePanel.Controls.Add(this.expandBtn);
            this.TitlePanel.Controls.Add(this.exitBtn);
            this.Animator.SetDecoration(this.TitlePanel, BunifuAnimatorNS.DecorationType.None);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.TitlePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.ShadowDecoration.Parent = this.TitlePanel;
            this.TitlePanel.Size = new System.Drawing.Size(1207, 46);
            this.TitlePanel.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.titleLabel, BunifuAnimatorNS.DecorationType.None);
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(211, 25);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Главная страница";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.CheckedState.Parent = this.minimizeBtn;
            this.Animator.SetDecoration(this.minimizeBtn, BunifuAnimatorNS.DecorationType.None);
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBtn.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.minimizeBtn.HoverState.Parent = this.minimizeBtn;
            this.minimizeBtn.Image = global::Mockup.Properties.Resources.BlueMinimize;
            this.minimizeBtn.ImageSize = new System.Drawing.Size(46, 46);
            this.minimizeBtn.Location = new System.Drawing.Point(988, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.minimizeBtn.PressedState.Parent = this.minimizeBtn;
            this.minimizeBtn.Size = new System.Drawing.Size(73, 46);
            this.minimizeBtn.TabIndex = 7;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // expandBtn
            // 
            this.expandBtn.BackColor = System.Drawing.Color.Transparent;
            this.expandBtn.CheckedState.Parent = this.expandBtn;
            this.Animator.SetDecoration(this.expandBtn, BunifuAnimatorNS.DecorationType.None);
            this.expandBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandBtn.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.expandBtn.HoverState.Parent = this.expandBtn;
            this.expandBtn.Image = global::Mockup.Properties.Resources.BlueExpand;
            this.expandBtn.ImageSize = new System.Drawing.Size(46, 46);
            this.expandBtn.Location = new System.Drawing.Point(1061, 0);
            this.expandBtn.Name = "expandBtn";
            this.expandBtn.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.expandBtn.PressedState.Parent = this.expandBtn;
            this.expandBtn.Size = new System.Drawing.Size(73, 46);
            this.expandBtn.TabIndex = 2;
            this.expandBtn.Click += new System.EventHandler(this.expandBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.Animator.SetDecoration(this.exitBtn, BunifuAnimatorNS.DecorationType.None);
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Image = global::Mockup.Properties.Resources.blueExit;
            this.exitBtn.ImageSize = new System.Drawing.Size(46, 46);
            this.exitBtn.Location = new System.Drawing.Point(1134, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.exitBtn.PressedState.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(73, 46);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation1;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.Container, BunifuAnimatorNS.DecorationType.None);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(260, 46);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(947, 653);
            this.Container.TabIndex = 9;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.SettingsButton);
            this.Menu.Controls.Add(this.EditorButton);
            this.Menu.Controls.Add(this.CalculationButton);
            this.Menu.Controls.Add(this.burgerMenuBtn);
            this.Menu.Controls.Add(this.CaloriesButton);
            this.Animator.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Menu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Menu.Location = new System.Drawing.Point(0, 46);
            this.Menu.Name = "Menu";
            this.Menu.ShadowDecoration.Parent = this.Menu;
            this.Menu.Size = new System.Drawing.Size(260, 653);
            this.Menu.TabIndex = 20;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Animated = true;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.SettingsButton.CheckedState.Parent = this.SettingsButton;
            this.SettingsButton.CustomImages.Parent = this.SettingsButton;
            this.Animator.SetDecoration(this.SettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.SettingsButton.FillColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.HoverState.Parent = this.SettingsButton;
            this.SettingsButton.Image = global::Mockup.Properties.Resources.settings_80px;
            this.SettingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingsButton.ImageOffset = new System.Drawing.Point(0, 17);
            this.SettingsButton.ImageSize = new System.Drawing.Size(36, 36);
            this.SettingsButton.Location = new System.Drawing.Point(0, 590);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.ShadowDecoration.Parent = this.SettingsButton;
            this.SettingsButton.Size = new System.Drawing.Size(260, 35);
            this.SettingsButton.TabIndex = 20;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingsButton.TextOffset = new System.Drawing.Point(0, -20);
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // EditorButton
            // 
            this.EditorButton.Animated = true;
            this.EditorButton.BackColor = System.Drawing.Color.Transparent;
            this.EditorButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.EditorButton.CheckedState.Parent = this.EditorButton;
            this.EditorButton.CustomImages.Parent = this.EditorButton;
            this.Animator.SetDecoration(this.EditorButton, BunifuAnimatorNS.DecorationType.None);
            this.EditorButton.FillColor = System.Drawing.Color.Transparent;
            this.EditorButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.EditorButton.ForeColor = System.Drawing.Color.White;
            this.EditorButton.HoverState.Parent = this.EditorButton;
            this.EditorButton.Image = global::Mockup.Properties.Resources.pencil_drawing_80px;
            this.EditorButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EditorButton.ImageOffset = new System.Drawing.Point(0, 17);
            this.EditorButton.ImageSize = new System.Drawing.Size(36, 36);
            this.EditorButton.Location = new System.Drawing.Point(0, 362);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.ShadowDecoration.Parent = this.EditorButton;
            this.EditorButton.Size = new System.Drawing.Size(260, 35);
            this.EditorButton.TabIndex = 18;
            this.EditorButton.Text = "Редактор";
            this.EditorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EditorButton.TextOffset = new System.Drawing.Point(0, -20);
            this.EditorButton.Click += new System.EventHandler(this.EditorButton_Click);
            // 
            // CalculationButton
            // 
            this.CalculationButton.Animated = true;
            this.CalculationButton.BackColor = System.Drawing.Color.Transparent;
            this.CalculationButton.BorderColor = System.Drawing.Color.Transparent;
            this.CalculationButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.CalculationButton.CheckedState.Parent = this.CalculationButton;
            this.CalculationButton.CustomImages.Parent = this.CalculationButton;
            this.Animator.SetDecoration(this.CalculationButton, BunifuAnimatorNS.DecorationType.None);
            this.CalculationButton.FillColor = System.Drawing.Color.Transparent;
            this.CalculationButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.CalculationButton.ForeColor = System.Drawing.Color.PowderBlue;
            this.CalculationButton.HoverState.Parent = this.CalculationButton;
            this.CalculationButton.Image = global::Mockup.Properties.Resources.calculator_80px;
            this.CalculationButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CalculationButton.ImageOffset = new System.Drawing.Point(0, 17);
            this.CalculationButton.ImageSize = new System.Drawing.Size(36, 36);
            this.CalculationButton.Location = new System.Drawing.Point(0, 293);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.ShadowDecoration.Parent = this.CalculationButton;
            this.CalculationButton.Size = new System.Drawing.Size(260, 35);
            this.CalculationButton.TabIndex = 19;
            this.CalculationButton.Text = "Расчёт потребления";
            this.CalculationButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalculationButton.TextOffset = new System.Drawing.Point(0, -20);
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // burgerMenuBtn
            // 
            this.burgerMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.burgerMenuBtn.CheckedState.Parent = this.burgerMenuBtn;
            this.Animator.SetDecoration(this.burgerMenuBtn, BunifuAnimatorNS.DecorationType.None);
            this.burgerMenuBtn.HoverState.Parent = this.burgerMenuBtn;
            this.burgerMenuBtn.Image = global::Mockup.Properties.Resources.BlueMenu;
            this.burgerMenuBtn.ImageSize = new System.Drawing.Size(48, 48);
            this.burgerMenuBtn.Location = new System.Drawing.Point(222, 6);
            this.burgerMenuBtn.Name = "burgerMenuBtn";
            this.burgerMenuBtn.PressedState.Parent = this.burgerMenuBtn;
            this.burgerMenuBtn.Size = new System.Drawing.Size(32, 32);
            this.burgerMenuBtn.TabIndex = 16;
            this.burgerMenuBtn.Click += new System.EventHandler(this.burgerMenuBtn_Click);
            // 
            // CaloriesButton
            // 
            this.CaloriesButton.Animated = true;
            this.CaloriesButton.BackColor = System.Drawing.Color.Transparent;
            this.CaloriesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(144)))), ((int)(((byte)(241)))));
            this.CaloriesButton.CheckedState.Parent = this.CaloriesButton;
            this.CaloriesButton.CustomImages.Parent = this.CaloriesButton;
            this.Animator.SetDecoration(this.CaloriesButton, BunifuAnimatorNS.DecorationType.None);
            this.CaloriesButton.FillColor = System.Drawing.Color.Transparent;
            this.CaloriesButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.CaloriesButton.ForeColor = System.Drawing.Color.White;
            this.CaloriesButton.HoverState.Parent = this.CaloriesButton;
            this.CaloriesButton.Image = global::Mockup.Properties.Resources.calories_80px;
            this.CaloriesButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaloriesButton.ImageOffset = new System.Drawing.Point(0, 17);
            this.CaloriesButton.ImageSize = new System.Drawing.Size(36, 36);
            this.CaloriesButton.Location = new System.Drawing.Point(0, 224);
            this.CaloriesButton.Name = "CaloriesButton";
            this.CaloriesButton.ShadowDecoration.Parent = this.CaloriesButton;
            this.CaloriesButton.Size = new System.Drawing.Size(260, 35);
            this.CaloriesButton.TabIndex = 17;
            this.CaloriesButton.Text = "Каллорийность";
            this.CaloriesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CaloriesButton.TextOffset = new System.Drawing.Point(0, -20);
            this.CaloriesButton.Click += new System.EventHandler(this.CaloriesButton_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TitlePanel;
            // 
            // blackIcons
            // 
            this.blackIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("blackIcons.ImageStream")));
            this.blackIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.blackIcons.Images.SetKeyName(0, "exit.png");
            this.blackIcons.Images.SetKeyName(1, "expand.png");
            this.blackIcons.Images.SetKeyName(2, "compress_96px.png");
            this.blackIcons.Images.SetKeyName(3, "rollDown.png");
            this.blackIcons.Images.SetKeyName(4, "BurgerMenu.png");
            this.blackIcons.Images.SetKeyName(5, "calories_96px.png");
            this.blackIcons.Images.SetKeyName(6, "calculator_96px.png");
            this.blackIcons.Images.SetKeyName(7, "pencil_96px.png");
            this.blackIcons.Images.SetKeyName(8, "settings_96px.png");
            // 
            // blueIcons
            // 
            this.blueIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("blueIcons.ImageStream")));
            this.blueIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.blueIcons.Images.SetKeyName(0, "blueExit.png");
            this.blueIcons.Images.SetKeyName(1, "BlueExpand.png");
            this.blueIcons.Images.SetKeyName(2, "collapseBlue.png");
            this.blueIcons.Images.SetKeyName(3, "BlueMinimize.png");
            this.blueIcons.Images.SetKeyName(4, "BlueMenu.png");
            this.blueIcons.Images.SetKeyName(5, "calories_80px.png");
            this.blueIcons.Images.SetKeyName(6, "calculator_80px.png");
            this.blueIcons.Images.SetKeyName(7, "pencil_drawing_80px.png");
            this.blueIcons.Images.SetKeyName(8, "settings_80px.png");
            // 
            // fadeTransition
            // 
            this.fadeTransition.Delay = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1207, 699);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.TitlePanel);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton expandBtn;
        private Guna.UI2.WinForms.Guna2ImageButton minimizeBtn;
        private Guna.UI2.WinForms.Guna2ImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ImageButton burgerMenuBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel TitlePanel;
        private Guna.UI2.WinForms.Guna2TileButton CaloriesButton;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.Panel Container;
        private Guna.UI2.WinForms.Guna2TileButton EditorButton;
        private Guna.UI2.WinForms.Guna2TileButton CalculationButton;
        private Guna.UI2.WinForms.Guna2GradientPanel Menu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2TileButton SettingsButton;
        private System.Windows.Forms.ImageList blackIcons;
        private System.Windows.Forms.ImageList blueIcons;
        private Bunifu.Framework.UI.BunifuFormFadeTransition fadeTransition;
        private System.Windows.Forms.Timer timer1;
    }
}

