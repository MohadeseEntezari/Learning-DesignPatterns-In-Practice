using TemplatePattern;

class Program
{
    static void Main()
    {
        IOrderRepository repository = new OrderRepository();

        Order onlineOrder = new Order { CustomerName = "Mohadese", Amount = 1000 };
        OrderProcessor onlineProcessor = new OnlineOrderProcessor(repository);
        onlineProcessor.ProcessOrder(onlineOrder);

        Console.WriteLine("----");

        Order phoneOrder = new Order { CustomerName = "Hadis", Amount = 500 };
        OrderProcessor phoneProcessor = new PhoneOrderProcessor(repository);
        phoneProcessor.ProcessOrder(phoneOrder);
    }
}
