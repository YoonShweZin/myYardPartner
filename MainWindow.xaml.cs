using System.Windows;

namespace MyYardPartner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Initialize and use instances of Volunteer, Visit, FeedbackHandler, and Client classes
            Volunteer volunteer = new Volunteer();
            Client client = new Client();
            FeedbackHandler feedbackHandler = new FeedbackHandler();

            // Perform actions using the created instances
            volunteer.Name = "John Doe";
            client.Name = "Jane Smith";

            Visit visit = new Visit(volunteer, client);
            visit.Date = DateTime.Now;
            visit.VolunteerSkill = "Gardening";

            // Add feedback using FeedbackHandler
            feedbackHandler.AddFeedback(visit, "Good job, John!");
            feedbackHandler.AddFeedback(visit, "Very satisfied with the service.");

            // View feedback for the volunteer
            List<Feedback> volunteerFeedbacks = feedbackHandler.ViewFeedbacks(volunteer);
            foreach (Feedback feedback in volunteerFeedbacks)
            {
                Console.WriteLine($"Volunteer Feedback: {feedback.Comment}");
            }

            // View feedback for the client
            List<Feedback> clientFeedbacks = feedbackHandler.ViewFeedbacks(client);
            foreach (Feedback feedback in clientFeedbacks)
            {
                Console.WriteLine($"Client Feedback: {feedback.Comment}");
            }
        }
    }
}
