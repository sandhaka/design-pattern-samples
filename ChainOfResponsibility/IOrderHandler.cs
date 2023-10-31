namespace ChainOfResponsibility;

public interface IOrderHandler
{
    void Add(IOrderHandler orderHandler);
    Task HandleAsync(Order order);
}