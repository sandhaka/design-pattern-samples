namespace ChainOfResponsibility;

public class ShippingOrderHandler : BaseOrderHandler
{
    protected override Task<bool> ProcessOrderAsync(Order order)
    {
        Console.WriteLine("Enter in Shipping handler: Collecting shipping information");
        
        if (new Random().NextDouble() <= 0.1)
        {
            Console.Error.WriteLine($"Wrong shipping information for order {order.Id}");
            return Task.FromResult(false);
        }
        
        Console.WriteLine("Shipping: OK");

        order.Shipped = true;

        return Task.FromResult(true);
    }
}