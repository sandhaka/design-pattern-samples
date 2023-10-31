using CliFx.Attributes;
using CliFx.Infrastructure;

namespace LaunchApp;

[Command(name: "Prototype", Description = "Execute Prototype Design Pattern Sample")]
public class PrototypeSample : CliFx.ICommand
{
    public ValueTask ExecuteAsync(IConsole console)
    {
        var demoApp = new Prototype.Application();
        
        demoApp.Run();
        
        return ValueTask.CompletedTask;
    }
}