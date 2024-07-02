public class Volunteer
{
    public int VolunteerID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public List<string> Skills { get; set; }
    public string TransportPref { get; set; }
    public string HealthForm { get; set; }
    public string BackgroundCheck { get; set; }
    public double TravelDistance { get; set; }
    public string SkillPref { get; set; }

    public List<Visit> Visits { get; set; } = new List<Visit>();
}
