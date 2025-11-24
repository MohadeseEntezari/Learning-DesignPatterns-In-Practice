namespace ObserverPattern;

internal interface IOrderSubject
{
    void Attach(IOrderObserver observer);
    void Detach(IOrderObserver observer);
    void Notify();
}
