using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_reservation
{
    internal class bookinginfo
    {
        private static List<bookinginfo> bi = new List<bookinginfo>();

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
        public string flightid { get; set; }


        public void save()
        {
            bi.Add(this);
        }
        public static List<bookinginfo> getall()
        {
            return bi;
        }
    }
}
