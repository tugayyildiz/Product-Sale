using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaret
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
            Database database = new Database();
            Application.Run(new girisEkran(database));
        }
    }
}
