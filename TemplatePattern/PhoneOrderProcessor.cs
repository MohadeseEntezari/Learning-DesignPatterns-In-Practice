namespace TemplatePattern;

public class PhoneOrderProcessor : OrderProcessor
{
    public PhoneOrderProcessor(IOrderRepository repository) : base(repository) { }

    protected override void Validate(Order order)
    {
        Console.WriteLine("Validating phone order...");
    }

    protected override void ApplyDiscount(Order order)
    {
        Console.WriteLine("No discount for phone order");
    }
}
