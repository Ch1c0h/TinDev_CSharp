using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinDev
{
    static class Program
    {

        public static string conexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TINDEV;Data Source=DESKTOP-C5UFP6N\SQLEXPRESS";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
