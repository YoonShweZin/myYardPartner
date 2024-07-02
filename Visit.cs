public class Visit
{
    public int VisitID { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string VolunteerSkill { get; set; }
    public string FeedbackVolunteer { get; set; }
    public string FeedbackClient { get; set; }

    public Volunteer Volunteer { get; set; }
    public Client Client { get; set; }

    public Visit(Volunteer volunteer, Client client)
    {
        Volunteer = volunteer;
        Client = client;
    }
}
