namespace StatePattern;

public class PaidState : IOrderState
{
    public PayResult Pay(OrderContext context)
    {
        return PayResult.AlreadyPaid;
    }
}
