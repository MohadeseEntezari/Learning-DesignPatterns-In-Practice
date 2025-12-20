namespace TemplatePattern;

public abstract class OrderProcessor
{
    protected readonly IOrderRepository _repository;

    protected OrderProcessor(IOrderRepository repository)
    {
        _repository = repository;
    }

    // Template Method
    public void ProcessOrder(Order order)
    {
        Validate(order);
        ApplyDiscount(order);
        _repository.Save(order);
        SendConfirmation(order);
    }

    protected abstract void Validate(Order order);
    protected abstract void ApplyDiscount(Order order);

    protected virtual void SendConfirmation(Order order)
    {
        Console.WriteLine($"Confirmation sent to {order.CustomerName}");
    }
}
