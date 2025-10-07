using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURENT_MANAGEMENT_SYSTEM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
<<<<<<< HEAD
           // Application.Run(new SalesReport());
=======
            //Application.Run(new SalesReport());
>>>>>>> 731f8650893d16d40ce68e5777e81258b6dbc946
            // Application.Run(new ReservationForm());
        }
    }
}
