using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYardPartner
{
    class Feedback
    {
        public Volunteer volunteer { get; }

        public Visit visit { get; set; }
        public string feedback { get; set; }
        public Volunteer Volunteer { get; }
        public Visit Visit { get; set; }
        public string FeedbackText { get; set; }

        public Feedback(string fb)
         {
             feedback = fb;
         }

         public override string ToString()
         {
             return volunteer.Name + " - " + visit.DateTime + visit.Info + visit.Feedback;
         }

    }
}
