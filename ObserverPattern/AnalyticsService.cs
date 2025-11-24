namespace ObserverPattern;
/// <summary>
/// Observer 2 - AnalyticsService
/// </summary>
internal class AnalyticsService : IOrderObserver
{
    public void Update(int currentOrders)
    {
        Console.WriteLine($"[ANALYTICS] Orders updated: {currentOrders}");
    }
}
