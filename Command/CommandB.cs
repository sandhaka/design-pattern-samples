namespace Command;

public class CommandB : Command
{
    public CommandB(BusinessReceiver receiver) : 
        base(receiver) { }

    public override Task Execute()
    {
        Receiver.OperationB();
        
        return Task.CompletedTask;
    }
}