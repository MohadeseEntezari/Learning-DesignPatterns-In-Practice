namespace ObserverPattern;
/// <summary>
/// Observer 3 - AutoScaleService
/// </summary>
internal class AutoScaleService : IOrderObserver
{
    public void Update(int currentOrders)
    {
        if (currentOrders > 100)
            Console.WriteLine("[AUTOSCALE] Scaling up servers...");
    }
}