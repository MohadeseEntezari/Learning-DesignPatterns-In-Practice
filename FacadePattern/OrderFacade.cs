namespace FacadePattern;

public class OrderFacade
{
    private readonly InventoryService _inventory;
    private readonly PaymentService _payment;
    private readonly ShippingService _shipping;
    private readonly NotificationService _notification;

    public OrderFacade()
    {
        _inventory = new InventoryService();
        _payment = new PaymentService();
        _shipping = new ShippingService();
        _notification = new NotificationService();
    }

    public void PlaceOrder(int productId, decimal amount, string email)
    {
        if (!_inventory.CheckStock(productId))
            throw new Exception("Product is out of stock");

        _payment.Pay(amount);
        _shipping.Ship(productId);
        _notification.SendEmail(email);

        Console.WriteLine("Order placed successfully!");
    }
}
