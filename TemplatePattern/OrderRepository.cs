namespace TemplatePattern;

public class OrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine($"Order for {order.CustomerName} saved with amount {order.Amount}");
    }
}
