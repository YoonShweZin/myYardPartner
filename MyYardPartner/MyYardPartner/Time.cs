using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYardPartner
{
    class Time
    {
        public string DDate { get; set; } //read write property
        public string TTime { get; set; }
        public string Period { get; set; }
        public List<Time> Times { get; }

        public Time(string date, string time, string period)
        {
            DDate = date;
            TTime = time;
            Period = period;
            Times = new List<Time>();
        }

        // Method to print the visit as text
        override public string ToString()
        {
            return "Date:(" + DDate + "), Time: " + TTime + ", " + Period;
        }
    }

}
