using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// Import Statments
namespace Airline_reservation
{
    static class Program
    {
        // Main Entry point of Application
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login()); // Setting Login Window as where to start
        }
    }
}
