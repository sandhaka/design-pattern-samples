using System.Collections.ObjectModel;

namespace ChainOfResponsibility;

public interface IOrderHandler
{
    public void Add(IOrderHandler orderHandler);
    public Task HandleAsync(Order order);
}