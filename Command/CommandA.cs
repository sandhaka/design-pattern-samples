namespace Command;

public class CommandA : Command
{
    public CommandA(BusinessReceiver receiver) : base(receiver) { }

    public override Task Execute()
    {
        Receiver.OperationA();
        
        return Task.CompletedTask;
    }
}