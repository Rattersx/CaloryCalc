
namespace Mockup
{
    partial class CaloriesRedactorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DishButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.ProductButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.ProductBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.DishBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DishButton);
            this.panel1.Controls.Add(this.ProductButton);
            this.panel1.Controls.Add(this.ProductBorder);
            this.panel1.Controls.Add(this.DishBorder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 44);
            this.panel1.TabIndex = 7;
            // 
            // DishButton
            // 
            this.DishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DishButton.CheckedState.Parent = this.DishButton;
            this.DishButton.CustomImages.Parent = this.DishButton;
            this.DishButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DishButton.ForeColor = System.Drawing.Color.White;
            this.DishButton.HoverState.Parent = this.DishButton;
            this.DishButton.Location = new System.Drawing.Point(489, 0);
            this.DishButton.Name = "DishButton";
            this.DishButton.ShadowDecoration.Parent = this.DishButton;
            this.DishButton.Size = new System.Drawing.Size(180, 44);
            this.DishButton.TabIndex = 1;
            this.DishButton.Text = "Блюда";
            this.DishButton.Click += new System.EventHandler(this.DishButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ProductButton.CheckedState.Parent = this.ProductButton;
            this.ProductButton.CustomImages.Parent = this.ProductButton;
            this.ProductButton.FillColor = System.Drawing.Color.LightSteelBlue;
            this.ProductButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductButton.ForeColor = System.Drawing.Color.White;
            this.ProductButton.HoverState.Parent = this.ProductButton;
            this.ProductButton.Location = new System.Drawing.Point(282, 0);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.ShadowDecoration.Parent = this.ProductButton;
            this.ProductButton.Size = new System.Drawing.Size(180, 44);
            this.ProductButton.TabIndex = 0;
            this.ProductButton.Text = "Продукты";
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // ProductBorder
            // 
            this.ProductBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ProductBorder.BackColor = System.Drawing.Color.Transparent;
            this.ProductBorder.BorderRadius = 60;
            this.ProductBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductBorder.Location = new System.Drawing.Point(259, -14);
            this.ProductBorder.Name = "ProductBorder";
            this.ProductBorder.ShadowDecoration.Parent = this.ProductBorder;
            this.ProductBorder.Size = new System.Drawing.Size(224, 136);
            this.ProductBorder.TabIndex = 3;
            // 
            // DishBorder
            // 
            this.DishBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DishBorder.BackColor = System.Drawing.Color.Transparent;
            this.DishBorder.BorderRadius = 60;
            this.DishBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DishBorder.Location = new System.Drawing.Point(467, -17);
            this.DishBorder.Name = "DishBorder";
            this.DishBorder.ShadowDecoration.Parent = this.DishBorder;
            this.DishBorder.Size = new System.Drawing.Size(224, 138);
            this.DishBorder.TabIndex = 4;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 44);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(947, 609);
            this.Container.TabIndex = 8;
            // 
            // CaloriesRedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(947, 653);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CaloriesRedactorForm";
            this.Text = "CaloriesRedactorForm";
            this.Load += new System.EventHandler(this.CaloriesRedactorForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Container;
        private Guna.UI2.WinForms.Guna2TileButton DishButton;
        private Guna.UI2.WinForms.Guna2TileButton ProductButton;
        private Guna.UI2.WinForms.Guna2Panel ProductBorder;
        private Guna.UI2.WinForms.Guna2Panel DishBorder;
    }
}