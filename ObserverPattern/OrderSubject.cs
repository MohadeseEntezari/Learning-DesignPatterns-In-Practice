namespace ObserverPattern;

internal class OrderSubject : IOrderSubject
{
    private readonly List<IOrderObserver> _observers = new();
    public int CurrentOrders { get; private set; }

    public void AddOrder()
    {
        CurrentOrders++;
        Notify();
    }

    public void Attach(IOrderObserver observer) => _observers.Add(observer);

    public void Detach(IOrderObserver observer) => _observers.Remove(observer);

    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(CurrentOrders);
    }
}
