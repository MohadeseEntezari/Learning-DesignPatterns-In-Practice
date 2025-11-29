namespace FactoryPattern;

internal class ZarinpalGateway : IPaymentGateway
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Zarinpal: Processing payment of {amount}.");
        return true;
    }

    public bool Refund(string transactionId)
    {
        Console.WriteLine($"Zarinpal: Refunding transaction {transactionId}.");
        return true;
    }
}
