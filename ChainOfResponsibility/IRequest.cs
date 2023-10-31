namespace ChainOfResponsibility;

public interface IRequest
{
    Guid Id { get; }
    DateTime Created { get; }
}