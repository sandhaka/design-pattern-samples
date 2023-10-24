namespace Command;

public abstract class Command : ICommand
{
    protected readonly BusinessReceiver Receiver;

    protected Command(BusinessReceiver receiver)
    {
        Receiver = receiver;
    }

    public abstract Task Execute();
}