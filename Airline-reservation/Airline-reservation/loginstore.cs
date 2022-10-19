using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_reservation
{
    internal class loginstore
    {
        private static List<loginstore> ls=new List<loginstore>();

        public string loginusername { get; set; }
        public string loginpassword { get; set; }

        public void save()
        {
            ls.Add(this);
        }
        public static List<loginstore> getall()
        {
            return ls;
        }

    }
}
