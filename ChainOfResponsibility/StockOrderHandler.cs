namespace ChainOfResponsibility;

public class StockOrderHandler : BaseOrderHandler
{
    protected override Task<bool> ProcessOrderAsync(Order order)
    {
        Console.WriteLine("Enter in Stock handler: Verify item availability");

        if (new Random().NextDouble() <= 0.1)
        {
            Console.Error.WriteLine($"Items {order.ItemCode} (No: {order.Quantity}) not available");
            return Task.FromResult(false);
        }
        
        Console.WriteLine("Availability: OK");

        return Task.FromResult(true);
    }
}