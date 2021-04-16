using Mockup.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    static class Program
    {
        public static Form1 parent;
        /// <summary>
        /// Главная точка входа для приложения. Vvovo
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (isCreated)
                Application.Run(new Form1());
            else
                Application.Run(new FirstStartForm());
        }
        private static bool isCreated
        {
            get
            {
                if (File.Exists("theme.json"))
                    return true;
                else
                    return false;
            }
        }
    }
}
