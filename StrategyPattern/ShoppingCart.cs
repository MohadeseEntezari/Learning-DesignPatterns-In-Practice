namespace StrategyPattern;

internal class ShoppingCart
{
    private IPaymentStrategy? paymentStrategy;

    // Setter method to change strategy at runtime
    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        this.paymentStrategy = strategy;
    }
    public void Checkout(double totalAmount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("Please select a payment method.");
            return;
        }

        Console.WriteLine("Starting the settlement process...");
        // Delegate work to the current strategy
        paymentStrategy.Pay(totalAmount);
    }
}
