namespace StatePattern;

public class OrderContext
{
    public IOrderState State { get; private set; }

    public OrderContext(IOrderState state)
    {
        State = state;
    }

    internal void ChangeState(IOrderState newState)
    {
        State = newState;
    }

    public PayResult Pay()
    {
        return State.Pay(this);
    }
}
