using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_reservation
{
    internal class flightinfo
    {
        private static List<flightinfo> fi = new List<flightinfo>();

        public string firstname { get; set; }
        public string lastname { get; set; }
     
        
        public string departuredate { get; set; }
        public string gender { get; set; }
        
        public string passportnumber { get; set; }
        public string email { get; set; }
        public string from { get; set; }
        public string to{ get; set; }
        public string age { get; set; }
        public string flightclass { get; set; }
        public string flighttype { get; set; }


        public void save()
        {
            fi.Add(this);
        }
        public static List<flightinfo> getall()
        {
            return fi;
        }
    }
}
