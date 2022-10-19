using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_reservation
{
    internal class registerstore
    {
        private static List<registerstore> rs= new List<registerstore>();

        public string registerfirstname { get; set; }
        public string registerlastname { get; set; }
        public string registerusername { get; set; }
        public string registerpassword { get; set; }
        public string registebirthdate { get; set; }
        public string registergender { get; set; }
        public string registerhint { get; set; }
        public string registerphone { get; set; }
        public string registeremail { get; set; }
        public string registerprofilepic { get; set; }


        public void save()
        {
            rs.Add(this);
        }
        public static List<registerstore> getall()
        {
            return rs;
        }
    }
}
