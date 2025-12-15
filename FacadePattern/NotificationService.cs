namespace FacadePattern;

public class NotificationService
{
    public void SendEmail(string email)
    {
        Console.WriteLine($"Sending email to {email}...");
    }
}
