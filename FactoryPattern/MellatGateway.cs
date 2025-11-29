namespace FactoryPattern;

internal class MellatGateway : IPaymentGateway
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Mellat: Processing payment of {amount}.");
        return true;
    }

    public bool Refund(string transactionId)
    {
        Console.WriteLine($"Mellat: Refunding transaction {transactionId}.");
        return true;
    }
}
