using Kamu_Medi_Care.LogIn;
using Kamu_Medi_Care.Medicines;
using Kamu_Medi_Care.Receptions;
using System;
using System.Windows.Forms;

namespace Kamu_Medi_Care
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
