namespace Command;

public class Application
{
    private readonly List<ICommand> _history = new();
    private readonly Queue<ICommand> _tasksQueue = new();
    
    public void CommandEnqueue(params ICommand[] commands)
    {
        foreach (var command in commands)
        {
            _tasksQueue.Enqueue(command);
        }
    }

    public async Task RunAsync()
    {
        while (_tasksQueue.Any())
        {
            var task = _tasksQueue.Dequeue();
            
            await task.Execute();
            
            _history.Add(task);
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Commands history: ");
        
        _history.ForEach(cmd => Console.WriteLine(cmd.GetType().Name));
    }
}