using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_reservation
{
    internal class forgotpasswordstore
    {
        private static List<forgotpasswordstore> fpws = new List<forgotpasswordstore>();

<<<<<<< HEAD
        public string fpusername { get; set; }
        public string fppassword { get; set; }
        public string fphint { get; set; }
=======
        public string fpsusername { get; set; }
        public string fpspassword { get; set; }
>>>>>>> 2f796ea864e5665aecdcb59fd039179c96cd060d
        

        public void save()
        {
            fpws.Add(this);
        }
        public static List<forgotpasswordstore> getall()
        {
            return fpws;
        }
    }
}
