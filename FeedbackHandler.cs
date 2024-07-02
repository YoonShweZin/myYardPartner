public class FeedbackHandler
{
    private List<Feedback> feedbackList = new List<Feedback>();

    public void AddFeedback(Visit visit, string feedback)
    {
        feedbackList.Add(new Feedback { Visit = visit, Comment = feedback });
    }

    public List<Feedback> ViewFeedbacks(Volunteer volunteer)
    {
        return feedbackList.Where(f => f.Visit.Volunteer == volunteer).ToList();
    }

    public List<Feedback> ViewFeedbacks(Client client)
    {
        return feedbackList.Where(f => f.Visit.Client == client).ToList();
    }
}
