namespace StrategyPattern;

/// <summary>
///  Strategy Interface
/// </summary>
internal interface IPaymentStrategy
{
    void Pay(double amount);
}
