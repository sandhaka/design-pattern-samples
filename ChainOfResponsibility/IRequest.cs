namespace ChainOfResponsibility;

public interface IRequest
{
    public Guid Id { get; }
    public DateTime Created { get; }
}