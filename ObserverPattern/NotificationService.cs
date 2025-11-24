namespace ObserverPattern;

/// <summary>
/// Observer 1 - NotificationService
/// </summary>
internal class NotificationService : IOrderObserver
{
    public void Update(int currentOrders)
    {
        if (currentOrders > 50)
            Console.WriteLine($"[NOTIFY] High order volume detected: {currentOrders}");
    }
}