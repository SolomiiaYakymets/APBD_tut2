namespace Tutorial2;

public class LiquidContainer: Container, IHazardNotifier
{
    private TypeLiquid _typeLiquid;
    
    public LiquidContainer(double mass, double height, double weight, double depth, double maxPlayload, string serialNum, TypeLiquid typeLiquid) : base(mass, height, weight, depth, maxPlayload, serialNum)
    {
        Mass = mass;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxPlayload = maxPlayload;
        SerialNum = CreatNum();
        _typeLiquid = typeLiquid;
    }

    public void HazardousSituation(string error)
    {
        throw new OverfillException(error + " in container " + SerialNum);
    }

    private string CreatNum()
    {
        int id = Count;
        Count++;
        return "KON-L-" + id;
    }

    public override void EmptyContainer()
    {
        Mass = 0;
    }

    public override void LoadContainer(double fillMass)
    {
        if (_typeLiquid == TypeLiquid.Hazardous)
        {
            MaxPlayload *= 0.5;
        }
        else if (_typeLiquid == TypeLiquid.Ordinary)
        {
            MaxPlayload *= 0.9;
        }

        if (Mass + fillMass < MaxPlayload)
        {
            Mass += fillMass;
        }
        else
        {
            HazardousSituation("An attempt to exceed the maximum capacity ");
        }
        
    }
}