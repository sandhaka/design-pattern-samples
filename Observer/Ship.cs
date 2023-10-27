namespace Observer;

public abstract class Ship : BaseSubject
{
    public string Name { get; init; }
    public ShipState State { get; set; } = ShipState.Docked;
    
    protected Ship(string name)
    {
        Name = name;
    }
    
    public void BackToSea()
    {
        Console.WriteLine($"{Name} ship is leaving the dock.");
        
        State = ShipState.Leaving;
        
        Notify();
    }

    public void Docking()
    {
        Console.WriteLine($"{Name} ship has been arrived at the port.");
        
        State = ShipState.Docking;
        
        Notify();
    }
    
    public void DockingEnd()
    {
        Console.WriteLine($"{Name} ship has been docked.");
        
        State = ShipState.Docked;
        
        Notify();
    }
}