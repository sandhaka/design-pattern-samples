namespace ChainOfResponsibility;

public class AccountabilityOrderHandler : BaseOrderHandler
{
    protected override Task<bool> ProcessOrderAsync(Order order)
    {
        Console.WriteLine("Enter in Accountability handler: Verify account status");
        
        Console.WriteLine("Account: OK");

        return Task.FromResult(true);
    }
}