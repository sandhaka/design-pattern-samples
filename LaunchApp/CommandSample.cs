using CliFx.Attributes;
using CliFx.Infrastructure;

namespace LaunchApp;

[Command(Description = "Execute Command Design Pattern")]
public class CommandSample : CliFx.ICommand
{
    public async ValueTask ExecuteAsync(IConsole console)
    {
        var demoApp = new Command.Application();
        var businessReceiver = new Command.BusinessReceiver();

        demoApp.CommandEnqueue(new Command.CommandA(businessReceiver));
        demoApp.CommandEnqueue(new Command.CommandB(businessReceiver));

        await demoApp.RunAsync();
        
        demoApp.ShowHistory();
    }
}