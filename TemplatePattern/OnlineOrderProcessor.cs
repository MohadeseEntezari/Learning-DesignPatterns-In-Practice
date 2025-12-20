namespace TemplatePattern;

public class OnlineOrderProcessor : OrderProcessor
{
    public OnlineOrderProcessor(IOrderRepository repository) : base(repository) { }

    protected override void Validate(Order order)
    {
        Console.WriteLine("Validating online order...");
        // اعتبارسنجی آنلاین
    }

    protected override void ApplyDiscount(Order order)
    {
        Console.WriteLine("Applying 10% online discount...");
        order.Amount *= 0.9m;
    }
}
