namespace ChainOfResponsibility;

public class FraudDetectionOrderHandler : BaseOrderHandler
{
    protected override Task<bool> ProcessOrderAsync(Order order)
    {
        Console.WriteLine("Enter in fraud detection handler: Detecting fraud");
        
        Console.WriteLine("Fraud detection: OK");

        return Task.FromResult(true);
    }
}