namespace Tutorial2;

public abstract class Container
{
    public double Mass { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public double MaxPlayload { get; set; }
    public string SerialNum { get; set; }

    public Container(double mass, double height, double weight, double depth, double maxPlayload)
    {
        Mass = mass;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxPlayload = maxPlayload;

    }
    
    public abstract void EmptyContainer();
    public abstract void LoadContainer(double fillMass);


}