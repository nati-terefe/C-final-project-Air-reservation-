using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_reservation
{
    internal class contactstore
    {
        private static List<contactstore> cs = new List<contactstore>();

        public string contactfirstname { get; set; }
        public string contactlastname { get; set; }
        public string contactemail { get; set; }
        public string contactmessage { get; set; }

        public void save()
        {
            cs.Add(this);
        }
        public static List<contactstore> getall()
        {
            return cs;
        }
    }
}
