
namespace Mockup
{
    partial class CaloriesValueForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaloriesValueForm));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Container = new System.Windows.Forms.Panel();
            this.DishBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.DishButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.Animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            this.Container.Location = new System.Drawing.Point(0, 44);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(947, 609);
            this.Container.TabIndex = 5;
            this.Container.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Paint);
            // 
            // DishBorder
            // 
            this.DishBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DishBorder.BackColor = System.Drawing.Color.Transparent;
            this.DishBorder.BorderRadius = 60;
            this.Animator.SetDecoration(this.DishBorder, BunifuAnimatorNS.DecorationType.None);
            this.DishBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DishBorder.Location = new System.Drawing.Point(467, -17);
            this.DishBorder.Name = "DishBorder";
            this.DishBorder.ShadowDecoration.Parent = this.DishBorder;
            this.DishBorder.Size = new System.Drawing.Size(224, 138);
            this.DishBorder.TabIndex = 10;
            // 
            // ProductBorder
            // 
            this.ProductBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ProductBorder.BackColor = System.Drawing.Color.Transparent;
            this.ProductBorder.BorderRadius = 60;
            this.Animator.SetDecoration(this.ProductBorder, BunifuAnimatorNS.DecorationType.None);
            this.ProductBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductBorder.Location = new System.Drawing.Point(259, -14);
            this.ProductBorder.Name = "ProductBorder";
            this.ProductBorder.ShadowDecoration.Parent = this.ProductBorder;
            this.ProductBorder.Size = new System.Drawing.Size(224, 136);
            this.ProductBorder.TabIndex = 9;
            // 
            // ProductButton
            // 
            this.ProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ProductButton.Animated = true;
            this.ProductButton.CheckedState.Parent = this.ProductButton;
            this.ProductButton.CustomImages.Parent = this.ProductButton;
            this.Animator.SetDecoration(this.ProductButton, BunifuAnimatorNS.DecorationType.None);
            this.ProductButton.FillColor = System.Drawing.Color.LightSteelBlue;
            this.ProductButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductButton.ForeColor = System.Drawing.Color.White;
            this.ProductButton.HoverState.Parent = this.ProductButton;
            this.ProductButton.Location = new System.Drawing.Point(282, 0);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.ShadowDecoration.Parent = this.ProductButton;
            this.ProductButton.Size = new System.Drawing.Size(180, 44);
            this.ProductButton.TabIndex = 5;
            this.ProductButton.Text = "Продукты";
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // DishButton
            // 
            this.DishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DishButton.Animated = true;
            this.DishButton.CheckedState.Parent = this.DishButton;
            this.DishButton.CustomImages.Parent = this.DishButton;
            this.Animator.SetDecoration(this.DishButton, BunifuAnimatorNS.DecorationType.None);
            this.DishButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DishButton.ForeColor = System.Drawing.Color.White;
            this.DishButton.HoverState.Parent = this.DishButton;
            this.DishButton.Location = new System.Drawing.Point(489, 0);
            this.DishButton.Name = "DishButton";
            this.DishButton.ShadowDecoration.Parent = this.DishButton;
            this.DishButton.Size = new System.Drawing.Size(180, 44);
            this.DishButton.TabIndex = 6;
            this.DishButton.Text = "Блюда";
            this.DishButton.Click += new System.EventHandler(this.DishButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DishButton);
            this.panel1.Controls.Add(this.ProductButton);
            this.panel1.Controls.Add(this.ProductBorder);
            this.panel1.Controls.Add(this.DishBorder);
            this.Animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 44);
            this.panel1.TabIndex = 4;
            // 
            // CaloriesValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(947, 653);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.panel1);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaloriesValueForm";
            this.Text = "CaloriesValueForm";
            this.Load += new System.EventHandler(this.CaloriesValueForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TileButton DishButton;
        private Guna.UI2.WinForms.Guna2TileButton ProductButton;
        private Guna.UI2.WinForms.Guna2Panel ProductBorder;
        private Guna.UI2.WinForms.Guna2Panel DishBorder;
    }
}