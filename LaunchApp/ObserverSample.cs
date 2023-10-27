using CliFx.Attributes;
using CliFx.Infrastructure;

namespace LaunchApp;

[Command(name: "Observer", Description = "Execute Observer Design Pattern Sample")]
public class ObserverSample : CliFx.ICommand
{
    public ValueTask ExecuteAsync(IConsole console)
    {
        var demoApp = new Observer.Application();
        
        demoApp.Run();

        return ValueTask.CompletedTask;
    }
}