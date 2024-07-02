using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyYardPartner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            createListClient();
        }

        // create a list for storing visits
        List<Client> ClientList = new List<Client>();
        List<Visit> VisitList = new List<Visit>();
        List<Time> TimeList = new List<Time>();


        private void createListClient()
        {

            Visit vi1 = new Visit("22/Nov/2023", "John", "Hard Working");
            Visit vi2 = new Visit("22/Nov/2023", "Kate", "Nice");
            Visit vi3 = new Visit("22/Nov/2023", "Mia", "Skillful");

            Volunteer v1 = new Volunteer("Rose", "EH2", "Bus");
            Volunteer v2 = new Volunteer("Lily", "EH1", "Car");
            Volunteer v3 = new Volunteer("Bob", "EH1", "Bicycle");
            Volunteer v8 = new Volunteer("Filli", "EH1", "Bicycle");
            Volunteer v4 = new Volunteer("Mia", "EH1", "Bicycle");
            Volunteer v5 = new Volunteer("Mary", "EH1", "Bicycle");
            Volunteer v6 = new Volunteer("Ban", "EH5", "Bicycle");
            Volunteer v7 = new Volunteer("Fiona", "EH3", "Bus");

            Client c1 = new Client("Sally", "(EH1)");
            Client c2 = new Client("James", "(EH2)");
            Client c3 = new Client("John", "(EH3)");
            Client c4 = new Client("Kate", "(EH5)");

            Time t1 = new Time("Tue", "4:30", "PM");
            Time t2 = new Time("Wed", "3:30", "PM");
            Time t3 = new Time("Mon", "2:30", "PM");
            Time t4 = new Time("Sat", "10:30", "AM");

            v1.AddTime(t1);
            v1.AddTime(t2);
            v2.AddTime(t3);
            v3.AddTime(t4);

            c1.AddVolunteer(v2);
            c1.AddVolunteer(v3);
            c1.AddVolunteer(v8);
            c1.AddVolunteer(v4);
            c2.AddVolunteer(v1);
            c1.AddVolunteer(v5);
            c4.AddVolunteer(v6);
            c3.AddVolunteer(v7);

            //assigned volunteer with their visit details
            v1.AddVisit(vi1);
            v3.AddVisit(vi2);
            v4.AddVisit(vi3);


            //add values to their respective listbox
            ClientList.Add(c1);
            ClientList.Add(c2);
            ClientList.Add(c3);
            ClientList.Add(c4);


            /*          VisitList.Add(v1);
                        VisitList.Add(v3);
                        VisitList.Add(v4);*/

            // Adding visits from volunteers to the global VisitList
            VisitList.AddRange(v1.Visit);
            VisitList.AddRange(v3.Visit);
            VisitList.AddRange(v4.Visit);

            TimeList.AddRange(v1.Time);
            TimeList.AddRange(v2.Time);
            TimeList.AddRange(v3.Time);

            lstClient.ItemsSource = ClientList;
            // Set VisitList as the ItemsSource for the VIsitListBox
            lstVisit.ItemsSource = VisitList;
            lstTime.ItemsSource = TimeList;
        }

        // method to change view when client is selected
        private void clientSelected(object sender, SelectionChangedEventArgs e)
        {
            Client c = lstClient.SelectedItem as Client;
            if (c != null)
            {
                lstVolunteer.ItemsSource = c.Volunteers;
            }
        }

        private void volunteerSelected(object sender, SelectionChangedEventArgs e)
        {
            Volunteer v = lstVolunteer.SelectedItem as Volunteer;
            if (v != null )
            {
                lstVisit.ItemsSource = v.Visit;
                lstTime.ItemsSource = v.Time;
            }
        }

        private void visitSelected(object sender, SelectionChangedEventArgs e)
        {
            Visit vi = lstVisit.SelectedItem as Visit;
            if (vi == null)
            {
                lstVisit.ItemsSource = null;
            }
        }

        private void lstTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // method to add selected times and volunteer to the list of booking details
        /* private void addBook(object sender, RoutedEventArgs e)
         {
             Client clie = lstClient.SelectedItem as Client;
             Volunteer volu = lstVolunteer.SelectedItem as Volunteer;
             Time tim = lstTime.SelectedItem as Time;
             if (volu != null && clie != null)
             {
                 clie.AddVolunteer(volu);
                 *//*volu.AddTime(tim);*//*
                 lstBooking.ItemsSource = null;
                 lstBooking.ItemsSource = clie.Volunteers;
                 *//*lstBooking.ItemsSource = volu.Time;*//*
             }
         }*/
         private void addBook(object sender, RoutedEventArgs e)
            {
                Client clie = lstClient.SelectedItem as Client;
                Volunteer volu = lstVolunteer.SelectedItem as Volunteer;
                Time tim = lstTime.SelectedItem as Time;

                // Create a list to store the selected volunteer's information
                /*List<Volunteer> selectedVolunteers = new List<Volunteer> { volu };
                List<Client> selectedClient = new List<Client> { clie };*/

                // Set the selected volunteer's information as the ItemsSource for lstBooking
                //lstBooking.ItemsSource = selectedVolunteers;
                //lstBooking.ItemsSource = selectedClient;
                details.Text = $"Client Name: {clie.Name}, Location: {clie.Type} ,Volunteer Name: {volu.Name}, Date: {tim.DDate} {tim.TTime}{tim.Period}";
        }

        private void details_TextChanged(object sender, TextChangedEventArgs e)
        {
            Client clie = lstClient.SelectedItem as Client;
            Volunteer volu = lstVolunteer.SelectedItem as Volunteer;

            // Create a list to store the selected volunteer's information
            //List<Volunteer> selectedVolunteers = new List<Volunteer> { volu };
            //List<Client> selectedClient = new List<Client> { clie };

            // Set the selected volunteer's information as the ItemsSource for lstBooking
            //details.Text = $"{clie.Name} {volu.Name} ";
        }

    }
}
