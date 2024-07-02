public class Client
{
    public int ClientID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public List<Visit> Visits { get; set; } = new List<Visit>();
}
