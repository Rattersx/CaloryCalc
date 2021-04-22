using Mockup.Forms;
using Mockup.Forms.AddForms;
using Mockup.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public partial class Form1 : Form
    {
        bool expanded = false;
        ThemeInfo theme = new ThemeInfo();
        public bool progressEnd = false;
        SplashScreen ss;
        public Form1()
        {
            Program.parent = this;

            InitializeComponent();

            ThemeReload();
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        #region [Theme]
        public void ThemeReload()
        {
            theme.GetTheme();
            InitTheme();
        }
        public void InitTheme()
        {
            if (theme.TitleColor1.Value != null)
            {
                TitlePanel.FillColor = theme.TitleColor1.Value;
                TitlePanel.FillColor2 = theme.TitleColor2.Value;

                Menu.FillColor = theme.MenuColor1.Value;
                Menu.FillColor2 = theme.MenuColor2.Value;

                this.BackColor = theme.ContainerTheme.Value;
                titleLabel.ForeColor = theme.ButtonTheme.Value;

                var buttons = Commands.GetAllControls(this, typeof(Guna.UI2.WinForms.Guna2TileButton));
                foreach (Control button in buttons)
                {
                    button.ForeColor = theme.ButtonTheme.Value;
                }
                if (theme.black)
                {
                    exitBtn.Image = blackIcons.Images[0];
                    if (expanded)
                        expandBtn.Image = blackIcons.Images[2];
                    else
                        expandBtn.Image = blackIcons.Images[1];
                    minimizeBtn.Image = blackIcons.Images[3];
                    burgerMenuBtn.Image = blackIcons.Images[4];
                    CaloriesButton.Image = blackIcons.Images[5];
                    CalculationButton.Image = blackIcons.Images[6];
                    EditorButton.Image = blackIcons.Images[7];
                    SettingsButton.Image = blackIcons.Images[8];
                }
                else
                {
                    exitBtn.Image = blueIcons.Images[0];
                    if (expanded)
                        expandBtn.Image = blueIcons.Images[2];
                    else
                        expandBtn.Image = blueIcons.Images[1];
                    minimizeBtn.Image = blueIcons.Images[3];
                    burgerMenuBtn.Image = blueIcons.Images[4];
                    CaloriesButton.Image = blueIcons.Images[5];
                    CalculationButton.Image = blueIcons.Images[6];
                    EditorButton.Image = blueIcons.Images[7];
                    SettingsButton.Image = blueIcons.Images[8];
                }
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            if (theme.black)
                expandBtn.Image = blackIcons.Images[1];
            else
                expandBtn.Image = blueIcons.Images[1];
        }

        #region [Exit/Size/Minimize buttons]
        private void expandBtn_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                if (theme.black)
                    expandBtn.Image = blackIcons.Images[1];
                else
                    expandBtn.Image = blueIcons.Images[1];
                expanded = false;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                if (theme.black)
                    expandBtn.Image = blackIcons.Images[2];
                else
                    expandBtn.Image = blueIcons.Images[2];
                expanded = true;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menu Buttons
        private void burgerMenuBtn_Click(object sender, EventArgs e)
        {
            if (burgerMenuBtn.Location.X != 10)
            {
                CaloriesButton.ForeColor = Menu.BackColor;
                EditorButton.ForeColor = Menu.BackColor;
                CalculationButton.ForeColor = Menu.BackColor;

                Menu.Visible = false;
                Menu.Width = 53;
                burgerMenuBtn.Location = new Point(10, burgerMenuBtn.Location.Y);
                Animator.ShowSync(Menu, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                CaloriesButton.ForeColor = Color.Black;
                EditorButton.ForeColor = Color.Black;
                CalculationButton.ForeColor = Color.Black;

                Menu.Visible = false;
                Menu.Width = 260;
                burgerMenuBtn.Location = new Point(222, burgerMenuBtn.Location.Y);
                Animator.ShowSync(Menu, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
        }
        private void EditorButton_Click(object sender, EventArgs e)
        {
            Program.parent.Width = 1200;
            AddFormToContainer(new CaloriesRedactorForm(theme),true);
            titleLabel.Text = EditorButton.Text;

            CaloriesButton.Checked = false;
            CalculationButton.Checked = false;
            EditorButton.Checked = true;
            SettingsButton.Checked = false;
        }

        private void CaloriesButton_Click(object sender, EventArgs e)
        {
            AddFormToContainer(new SplashScreen(theme), true);
            CaloriesButton.Enabled = false;
            CalculationButton.Enabled = false;
            SettingsButton.Enabled = false;
            EditorButton.Enabled = false;
            splashScreenTimer.Start();
            AddFormToContainer(new CaloriesValueForm(theme),false);
            titleLabel.Text = CaloriesButton.Text;

            CaloriesButton.Checked = true;
            CalculationButton.Checked = false;
            EditorButton.Checked = false;
            SettingsButton.Checked = false;
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            Program.parent.Width = 1200;
            AddFormToContainer(new CaloriesCalculationForm(theme), true);
            titleLabel.Text = CalculationButton.Text;

            CaloriesButton.Checked = false;
            CalculationButton.Checked = true;
            EditorButton.Checked = false;
            SettingsButton.Checked = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Program.parent.Width = 1200;
            AddFormToContainer(new SettingsForm(theme), true);


            CaloriesButton.Checked = false;
            CalculationButton.Checked = false;
            EditorButton.Checked = false;
            SettingsButton.Checked = true;
        }
        #endregion
        private void ContainerRemoveItems()
        {
            foreach (Control item in Container.Controls)
            {
                Container.Controls.Remove(item);
            }
        }
        private void ContainerAddItem(object f)
        {
            Form form = f as Form;
            Container.Controls.Add(form);
            Container.Tag = form;
            form.Visible = true;
            form.Show();
        }
        private delegate void ContainerRemoveItemsDelegate();
        private delegate void ContainerAddItemDelegate(object f);
        private void AddFormToContainer(object form, bool deleteIsNeeded)
        {
            if (deleteIsNeeded)
            {
                Container.BeginInvoke(new ContainerRemoveItemsDelegate(ContainerRemoveItems));
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                Container.BeginInvoke(new ContainerAddItemDelegate(ContainerAddItem), f);
            }
            else
            {
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                Container.BeginInvoke(new ContainerAddItemDelegate(ContainerAddItem), f);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity -= 0.05;
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Opacity = 1.0;
                timer1.Stop();
            }
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            if (progressEnd)
            {
                
                CaloriesButton.Enabled = true;
                CalculationButton.Enabled = true;
                SettingsButton.Enabled = true;
                EditorButton.Enabled = true;
                progressEnd = false;
                splashScreenTimer.Stop();
            }
        }
    }
}
