namespace ChainOfResponsibility;

public class Application
{
    private IOrderHandler? _entryPoint;
    
    public void Configure()
    {
        var stock = new StockOrderHandler();
        var account = new AccountabilityOrderHandler();
        var fraudDet = new FraudDetectionOrderHandler();
        var payment = new PaymentOrderHandler();
        var shipping = new ShippingOrderHandler();
        
        /*
         * Linear chain:
         * stock -> account -> fraud detection -> payment -> shipping
         */
        
        stock.Add(account);
        account.Add(fraudDet);
        fraudDet.Add(payment);
        payment.Add(shipping);

        _entryPoint = stock;
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"Processing order: {order}");
        
        _entryPoint?.HandleAsync(order).Wait();
        
        Console.WriteLine($"Order status: {order}");
    }
}