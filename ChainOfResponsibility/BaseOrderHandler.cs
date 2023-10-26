using System.Collections.ObjectModel;

namespace ChainOfResponsibility;

public abstract class BaseOrderHandler : IOrderHandler
{
    private ICollection<IOrderHandler> Children { get; } = new Collection<IOrderHandler>();

    public void Add(IOrderHandler orderHandler)
    {
        Children.Add(orderHandler);
    }

    public async Task HandleAsync(Order order)
    {
        var passNext = await ProcessOrderAsync(order);
        
        if (passNext)
        {
            foreach (var handler in Children)
            {
                await handler.HandleAsync(order);
            }
        }
        else
        {
            Console.WriteLine($"Process interrupted at: {GetType().Name} handler");
        }
    }

    protected abstract Task<bool> ProcessOrderAsync(Order order);
}