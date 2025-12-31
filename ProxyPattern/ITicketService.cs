namespace ProxyPattern;

public interface ITicketService
{
    Task<TicketDto> GetTicketAsync(string ticketNumber);
}
