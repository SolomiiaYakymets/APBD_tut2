namespace Tutorial2;

public class LiquidContainer: Container, IHazardNotifier
{
    public TypeLiquid TypeLiquid;
    private static int _count;
    public LiquidContainer(double mass, double height, double weight, double depth, double maxPlayload, TypeLiquid typeLiquid) : base(mass, height, weight, depth, maxPlayload )
    {
        Mass = mass;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxPlayload = maxPlayload;
        SerialNum = CreatNum();
        TypeLiquid = typeLiquid;
    }

    public void HazardousSituation(string error)
    {
        throw new OverfillException(error + " in container " + SerialNum);
    }

    private string CreatNum()
    {
        int id = _count;
        _count++;
        return "KON-L-" + id;
    }

    public override void EmptyContainer()
    {
        Mass = 0;
    }

    public override void LoadContainer(double fillMass)
    {
        if (TypeLiquid == TypeLiquid.Fuel)
        {
            MaxPlayload *= 0.5;
        }
        else if (TypeLiquid == TypeLiquid.Milk)
        {
            MaxPlayload *= 0.9;
        }

        if (Mass + fillMass <= MaxPlayload)
        {
            Mass += fillMass;
        }
        else
        {
            HazardousSituation("An attempt to exceed the maximum capacity ");
        }
        
    }
}
