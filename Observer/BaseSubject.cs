using System.Collections.ObjectModel;

namespace Observer;

public abstract class BaseSubject : ISubject
{
    private readonly ICollection<IObserver> _subscribers = new Collection<IObserver>();
    
    public void Subscribe(IObserver observer)
    {
        _subscribers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _subscribers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(this);
        }
    }
}