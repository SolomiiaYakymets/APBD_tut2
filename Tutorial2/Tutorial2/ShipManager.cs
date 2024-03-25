namespace Tutorial2;

public class ShipManager
{
    public void TransferContainer(Ship ship1, Ship ship2, Container container)
    {
        ship1.RemoveContainer(container);
        ship2.LoadContainer(container);
    }
    public void PrintShip(Ship ship)
    {
        Console.WriteLine("Maximum speed: " + ship.MaxSpeed + "; Maximum number of containers: " + ship.MaxNumOfContainers + "; Maximum weight of containers: " + ship.MaxWeightOfContainers + "; " + ship.Cargo());
    }
}