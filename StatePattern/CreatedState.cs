namespace StatePattern;

public class CreatedState : IOrderState
{
    public PayResult Pay(OrderContext context)
    {
        context.ChangeState(new PaidState());
        return PayResult.Success;
    }
}
