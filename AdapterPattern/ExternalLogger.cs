public class ExternalLogger
{
    public void WriteLog(string text, int severity)
    {
        Console.WriteLine($"[Severity:{severity}] {text}");
    }
}
