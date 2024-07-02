using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYardPartner
{
    class Book
    {
        public List<Volunteer> Volunteers { get; set; }
        public List<Client> Clients { get; set; }
        public List<Time> Times { get; set; }

        public Client client { get; }
        public Time time { get; }

        public Volunteer volunteer { get; }

        public Book()
        {
            Volunteers = new List<Volunteer>();
            Clients = new List<Client>();
            Times = new List<Time>();
        }

        /*        public void AddVOL(Volunteer volunt)
                {
                    Volunteers.Add(volunt);
                }

                public void RemoveVOL(Volunteer volunt)
                {
                    Volunteers.Remove(volunt);
                }

                public void AddCLI(Client clie)
                {
                    Clients.Add(clie);
                }*/
        public override string ToString()
        {
            return "ClientName: " + client.Name + "VolunteetName:" + volunteer.Name + " - " + time.DDate + time.TTime + time.Period;
        }

    }

}
