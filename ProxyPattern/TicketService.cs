namespace ProxyPattern;

public class TicketService : ITicketService
{
    public async Task<TicketDto> GetTicketAsync(string ticketNumber)
    {
        // Simulate expensive external call
        await Task.Delay(2000);

        return new TicketDto
        {
            TicketNumber = ticketNumber,
            PassengerName = "John Doe",
            Price = 120_000
        };
    }
}
