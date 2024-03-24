namespace Tutorial2;

public abstract class Container
{
    public double Mass { get; set; }
    public double Height { get; }
    public double Weight { get; }
    public double Depth { get; }
    public double MaxPlayload { get; }
    public double Count { get; set; }
    public string SerialNum { get; set; }

    public Container(double mass, double height, double weight, double depth, double maxPlayload, string serialNum )
    {
        Mass = mass;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxPlayload = maxPlayload;
        SerialNum = serialNum;

    }

    public abstract string Identifier();
    public abstract void EmptyContainer();
    public abstract void LoadContainer();


}