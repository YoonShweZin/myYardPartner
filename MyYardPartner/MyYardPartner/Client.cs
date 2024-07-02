using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYardPartner
{
    class Client
    {

        public string Name { get; set; } //read write property
        public string Type { get; }
        public List<Volunteer> Volunteers { get; }

        // Constructor
        public Client(string n, string t)
        {
            Name = n;
            Type = t;
            Volunteers = new List<Volunteer>();
        }

        // Methods
        public void AddVolunteer(Volunteer v)
        {
            Volunteers.Add(v);
            v.AddClient(this);
        }


        // Method to print the client as text
        override public string ToString()
        {
            return "Name:" + Name + ", Address:" + Type;
        }

    }
}
