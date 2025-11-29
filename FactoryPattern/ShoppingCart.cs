namespace FactoryPattern;

public class ShoppingCart
{
    private readonly PaymentGatewayFactory _factory = new PaymentGatewayFactory();

    public void Checkout(decimal totalAmount, string selectedGatewayType)
    {
        Console.WriteLine($"\n--- Starting Checkout for Amount: {totalAmount} ---");

        try
        {
            IPaymentGateway gateway = _factory.GetGateway(selectedGatewayType);

            bool success = gateway.ProcessPayment(totalAmount);

            if (success)
            {
                Console.WriteLine("Checkout Successful! Transaction recorded.");
            }
            else
            {
                Console.WriteLine("Checkout Failed! Please try again.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during checkout: {ex.Message}");
        }
    }
}