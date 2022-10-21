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

        public string fpusername { get; set; }
        public string fppassword { get; set; }
        public string fphint { get; set; }
        

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
