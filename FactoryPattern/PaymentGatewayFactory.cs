namespace FactoryPattern;

internal class PaymentGatewayFactory
{
    internal IPaymentGateway GetGateway(string gatewayType)
    {
        if (string.IsNullOrEmpty(gatewayType))
        {
            throw new ArgumentException("Gateway type cannot be null or empty.");
        }

        return gatewayType.ToLowerInvariant() switch
        {
            "zarin" => new ZarinpalGateway(),
            "mellat" => new MellatGateway(),
            _ => throw new NotImplementedException($"Gateway '{gatewayType}' is not supported.")
        };
    }
}
