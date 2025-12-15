using System;

class Program
{
    static void Main()
    {
        ILogService logger =
            new ExternalLoggerAdapter(new ExternalLogger());

        logger.Log("Application started");
    }
}
