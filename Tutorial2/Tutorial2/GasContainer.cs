namespace Tutorial2;

public class GasContainer: Container, IHazardNotifier
{
    public double Pressure;
    private static int _count;
    
    public GasContainer(double mass, double height, double weight, double depth, double maxPlayload, double pressure) : base(mass, height, weight, depth, maxPlayload)
    {
        Mass = mass;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxPlayload = maxPlayload;
        SerialNum = CreatNum();
        Pressure = pressure;
    }
    
    private string CreatNum()
    {
        int id = _count;
        _count++;
        return "KON-G-" + id;
    }
    
    public override void EmptyContainer()
    {
        Mass -= Mass*0.95;
    }

    public override void LoadContainer(double fillMass)
    {
        if (Mass + fillMass <= MaxPlayload)
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