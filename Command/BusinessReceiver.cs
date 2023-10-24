namespace Command;

/// <summary>
/// Contain some important logic. Knows how to perform the concrete actions.
/// In a real application more then one are usually present as "services".
/// </summary>
public class BusinessReceiver
{
    internal void OperationA()
    {
        Console.WriteLine("Perform A operation...");
    }
    
    internal void OperationB()
    {
        Console.WriteLine("Perform B operation...");
    }
}
