using CliFx.Attributes;
using CliFx.Infrastructure;

namespace LaunchApp;

[Command(name: "Cor", Description = "Execute Chain Of Responsibility Design Pattern Sample")]
public class ChainOfResponsibilitySample : CliFx.ICommand
{
    public ValueTask ExecuteAsync(IConsole console)
    {
        var demoApp = new ChainOfResponsibility.Application();
        
        demoApp.Configure();

        demoApp.PlaceOrder(new ChainOfResponsibility.Order("ITEM-0938576", 99.98m, 10));
        
        return ValueTask.CompletedTask;
    }
}