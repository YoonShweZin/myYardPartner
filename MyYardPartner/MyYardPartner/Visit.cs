using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYardPartner
{
    class Visit
    {
        public string DateTime { get; } //read write property
        public string Info { get; }
        public string Feedback { get; }
        public List<Visit> Visits { get; }
        public List<Feedback> FeedbackList { get; }

        public Visit(string dt , string info, string  fb)
        {
            DateTime = dt;
            Info = info;
            Feedback = fb;
            Visits = new List<Visit>();
            FeedbackList = new List<Feedback>();
        }

        // Method to print the visit as text
        override public string ToString()
        {
            return "ClientName:(" + Info + "), Feedback: " + Feedback + ", Date:" +DateTime ;
        }
    }
}
