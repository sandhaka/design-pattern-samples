namespace Observer;

public class Application
{
    private readonly TradingPort _tradingPort = new();
    private readonly FishingBoat _fishingBoat = new("St. Luis");
    private readonly CargoShip _cargoShip = new("WhiteHat");

    private readonly BoatCruises[] _boatCruises = {
        new("St. Loren"),
        new("Maddalena"),
        new("Black Jack")
    };

    public Application()
    {
        _fishingBoat.Subscribe(_tradingPort);
        _cargoShip.Subscribe(_tradingPort);
        
        foreach (var cruises in _boatCruises)
        {
            cruises.Subscribe(_tradingPort);
        }
    }
    
    public void Run()
    {
        _boatCruises[0].BackToSea();
        _boatCruises[2].BackToSea();
        
        Thread.Sleep(1000);
        
        _fishingBoat.BackToSea();
        
        Thread.Sleep(1000);

        _cargoShip.BackToSea();
        
        Thread.Sleep(1000);

        _cargoShip.Docking();
        _fishingBoat.Docking();
        _boatCruises[0].Docking();
        _boatCruises[2].Docking();
        
        _cargoShip.DockingEnd();
        _fishingBoat.DockingEnd();
        _boatCruises[0].DockingEnd();
        _boatCruises[2].DockingEnd();
    }
}