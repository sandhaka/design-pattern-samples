namespace Observer;

public interface ISubject
{
    public void Subscribe(IObserver observer);
    public void Unsubscribe(IObserver observer);
    public void Notify();
}