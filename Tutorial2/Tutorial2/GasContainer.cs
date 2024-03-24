namespace Tutorial2;

public class GasContainer: Container, IHazardNotifier
{
    private double _pressure;
    
    public GasContainer(double mass, double height, double weight, double depth, double maxPlayload, string serialNum, double pressure) : base(mass, height, weight, depth, maxPlayload, serialNum)
    {
        Mass = mass;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxPlayload = maxPlayload;
        SerialNum = CreatNum();
        _pressure = pressure;
    }
    
    private string CreatNum()
    {
        int id = Count;
        Count++;
        return "KON-G-" + id;
    }
    
    public override void EmptyContainer()
    {
        Mass -= Mass*0.05;
    }

    public override void LoadContainer(double fillMass)
    {
        Mass += fillMass;
        
        if (Mass + fillMass < MaxPlayload)
        {
            Mass += fillMass;
        }
        else
        {
            HazardousSituation("An attempt to exceed the maximum capacity ");
        }
    }

    public void HazardousSituation(string error)
    {
        throw new OverfillException(error + " in container " + SerialNum);
    }
}