using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYardPartner
{
    class Volunteer
    {

        public string Name { get; set; }
        public string Address { get; }
        public string Preference { get; set; }

        public List<Client> Client { get; }
        public List<Visit> Visit { get; }
        public List<Time> Time { get; }
        public List<Feedback> FeedbackList { get; }

        public Volunteer(string n, string c, string prefer)
        {
            Name = n;
            Address = c;
            Preference = prefer;
            Client = new List<Client>();
            Visit = new List<Visit>();
            Time = new List<Time>();
            FeedbackList = new List<Feedback>();
        }


        public void AddClient(Client p)
        {
            Client.Add(p);
        }

        public void AddVisit(Visit vi)
        {
            Visit.Add(vi);
        }

        public void AddTime(Time t)
        {
            Time.Add(t);
        }

       /* public void AddFeedback(Visit visit, string feedbackText)
        {
            Feedback feedback = new Feedback(this, visit, feedbackText);
            FeedbackList.Add(feedback);
        }
*/
        // Method to print the volunteer as text
        override public string ToString()
        {
            return "Area:(" + Address + ") ,"+" Name:" + Name +", Transport:"+ Preference;
        }
    }
}
