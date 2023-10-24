namespace Command;

internal interface ICommand
{
    public Task Execute();
}