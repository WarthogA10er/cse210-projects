public class Commment
{
    private string _commentText;
    private string _commenterName;

    public void SetComment(string commentText, string commenterName)
    {
        _commentText = commentText;
        _commenterName = commenterName;
    }

    public void Display()
    {
        Console.WriteLine($"\n\n{_commentText}\n    --{_commenterName}--");
    }
}