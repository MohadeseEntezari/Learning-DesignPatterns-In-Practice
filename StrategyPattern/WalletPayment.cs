namespace StrategyPattern;
/// <summary>
/// Concrete Strategy 1
/// </summary>
public class WalletPayment : IPaymentStrategy
{
    private double currentBalance;

    public WalletPayment(double initialBalance)
    {
        this.currentBalance = initialBalance;
    }

    public void Pay(double amount)
    {
        if (currentBalance >= amount)
        {
            currentBalance -= amount;
            Console.WriteLine($"Payment of {amount} Tomans was made using the wallet.");
            Console.WriteLine($"Remaining balance: {currentBalance} Tomans.");
        }
        else
        {
            Console.WriteLine($"Insufficient wallet balance. Required amount: {amount} Tomans.");
        }
    }
}
