namespace Observer;

public class TradingPort : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject is CargoShip cargoShip)
        {
            if (cargoShip.State == ShipState.Docking)
            {
                Console.WriteLine($"TRADING PORT: Cargo {cargoShip.Name} arriving at the trading port, unloading preparation.");
            }
            
            if (cargoShip.State == ShipState.Docked)
            {
                Console.WriteLine($"TRADING PORT: Cargo {cargoShip.Name} in the trading port, unloading started.");
            }

            if (cargoShip.State == ShipState.Leaving)
            {
                Console.WriteLine($"TRADING PORT: Cargo {cargoShip.Name} departing from the trading port.");
            }
        }
    }
}