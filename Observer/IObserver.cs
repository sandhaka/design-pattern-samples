namespace Observer;

public interface IObserver
{
    public void Update(ISubject subject);
}