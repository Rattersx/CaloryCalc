using Mockup.Forms.AddForms;
using Mockup.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public partial class Form1 : Form
    {
        bool expanded = false;
        ThemeInfo theme = new ThemeInfo();
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
            AddFormToContainer(new CaloriesRedactorForm(theme));
            titleLabel.Text = EditorButton.Text;
        }

        private void CaloriesButton_Click(object sender, EventArgs e)
        {
            AddFormToContainer(new CaloriesValueForm(theme));
            titleLabel.Text = CaloriesButton.Text;
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            AddFormToContainer(new CaloriesCalculationForm(theme));
            titleLabel.Text = CalculationButton.Text;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            AddFormToContainer(new SettingsForm(theme));
        }
        #endregion

        private void AddFormToContainer(object form)
        {
            foreach (Control item in Container.Controls)
            {
                Container.Controls.Remove(item);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            Container.Controls.Add(f);
            Container.Tag = f;
            f.Visible = true;
            f.Show();
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
    }
}
