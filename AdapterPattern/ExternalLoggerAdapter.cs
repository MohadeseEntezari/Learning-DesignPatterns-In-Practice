public class ExternalLoggerAdapter : ILogService
{
    private readonly ExternalLogger _externalLogger;

    public ExternalLoggerAdapter(ExternalLogger externalLogger)
    {
        _externalLogger = externalLogger;
    }

    public void Log(string message)
    {
        _externalLogger.WriteLog(message, severity: 1);
    }
}