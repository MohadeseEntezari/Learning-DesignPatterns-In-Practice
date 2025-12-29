namespace StatePattern;

public interface IOrderState
{
    PayResult Pay(OrderContext context);
}
