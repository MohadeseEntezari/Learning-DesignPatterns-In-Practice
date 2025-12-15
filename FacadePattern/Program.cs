using FacadePattern;

class Program
{
    static void Main()
    {
        var orderFacade = new OrderFacade();
        orderFacade.PlaceOrder(1, 500_000, "user@test.com");
    }
}