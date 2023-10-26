namespace ChainOfResponsibility;

public class PaymentOrderHandler : BaseOrderHandler
{
    protected override Task<bool> ProcessOrderAsync(Order order)
    {
        Console.WriteLine("Enter in Payment handler: Payment");
        
        if (new Random().NextDouble() <= 0.1)
        {
            Console.Error.WriteLine($"Payment denied for order {order.Id}, created at {order.Created.ToShortDateString()}");
            return Task.FromResult(false);
        }
        
        Console.WriteLine("Payment: OK");

        order.Paid = true;

        return Task.FromResult(true);
    }
}