namespace FactoryPattern;

internal interface IPaymentGateway
{
    bool ProcessPayment(decimal amount);

    bool Refund(string transactionId);
}
