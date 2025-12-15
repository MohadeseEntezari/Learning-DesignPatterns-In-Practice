namespace FacadePattern;

public class PaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount}...");
    }
}
