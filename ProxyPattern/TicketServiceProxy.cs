namespace ProxyPattern;

public class TicketServiceProxy : ITicketService
{
    private readonly ITicketService _realService;
    private readonly Dictionary<string, TicketDto> _cache = new();

    public TicketServiceProxy(ITicketService realService)
    {
        _realService = realService;
    }

    public async Task<TicketDto> GetTicketAsync(string ticketNumber)
    {
        // Access control
        if (string.IsNullOrWhiteSpace(ticketNumber))
            throw new UnauthorizedAccessException("Invalid ticket number");

        // Caching
        if (_cache.TryGetValue(ticketNumber, out var cachedTicket))
        {
            Console.WriteLine("Returned from cache");
            return cachedTicket;
        }

        Console.WriteLine("Calling real service...");
        var ticket = await _realService.GetTicketAsync(ticketNumber);

        _cache[ticketNumber] = ticket;
        return ticket;
    }
}
