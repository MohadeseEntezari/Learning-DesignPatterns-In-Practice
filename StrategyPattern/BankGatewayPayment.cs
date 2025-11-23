namespace StrategyPattern;
/// <summary>
/// Concrete Strategy2
/// </summary>
public class BankGatewayPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"The payment of {amount} Tomans was successfully made through the banking portal.");
    }
}