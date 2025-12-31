using ProxyPattern;

class Program
{
    static async Task Main()
    {
        ITicketService service =
            new TicketServiceProxy(new TicketService());

        var ticket1 = await service.GetTicketAsync("ABC123");
        var ticket2 = await service.GetTicketAsync("ABC123");
    }
}
