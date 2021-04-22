using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup.Forms
{
    public partial class SplashScreen : Form
    {
        Themes.ThemeInfo theme = new Themes.ThemeInfo();
        Random r = new Random();
        bool reversed = true;
        public SplashScreen(Themes.ThemeInfo _theme)
        {
            InitializeComponent();
            theme = _theme;
            Commands.ApplyTheme(this, theme);
            timer1.Start();
        }
        int dir = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.parent.progressEnd)
            {
                this.Close();
            }
        }
    }
}
