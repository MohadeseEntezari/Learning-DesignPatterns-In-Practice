namespace ProxyPattern;

public class TicketDto
{
    public string TicketNumber { get; set; } = default!;
    public string PassengerName { get; set; } = default!;
    public decimal Price { get; set; }
}
