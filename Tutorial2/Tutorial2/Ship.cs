namespace Tutorial2;

public class Ship
{
    public double MaxSpeed;
    public int MaxNumOfContainers;
    public double MaxWeightOfContainers;
    public List<Container> Containers = new List<Container>();

    public Ship(double maxSpeed, int maxNumOfContainers, double maxWeightOfContiners )
    {
        MaxSpeed = maxSpeed;
        MaxNumOfContainers = maxNumOfContainers;
        MaxWeightOfContainers = maxWeightOfContiners;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count + 1 <= MaxNumOfContainers & TotalWeightOfContainers(Containers) + container.Mass <= MaxWeightOfContainers )
        {
            Containers.Add(container);
        }
        else
        {
            throw new Exception("There isn't enough space in the ship.");
        }
    }

    public double TotalWeightOfContainers(List<Container> containers)
    {
        double sum = 0;
        foreach (var t in containers)
        {
            sum += t.Mass;
        }

        return sum;
    }
    
    public void LoadContainerList(List<Container> containersList)
    {
        if (Containers.Count + containersList.Count <= MaxNumOfContainers & TotalWeightOfContainers(Containers) + TotalWeightOfContainers(containersList) <= MaxWeightOfContainers )
        {
            foreach (Container container in containersList)
            {
                Containers.Add(container);
            }
        }
        else
        {
            throw new Exception("There isn't enough space in the ship.");
        }
    }
    public void RemoveContainer(Container container)
    {
        if (!Containers.Contains(container))
        {
            throw new Exception("There is no such container in the ship.");
        }
        
        Containers.Remove(container);
    }
    
    public void ReplaceContainer(string containerNum, Container container)
    {
        bool containerFound = false;
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].SerialNum == containerNum)
            {
                Containers[i] = container;
                containerFound = true;
                break;
            }
        }
        if (!containerFound)
        {
            throw new Exception("There is no such container in the ship.");
        }
    }
    public void PrintContainer(Container container)
    {
        bool containerFound = false;
        foreach (var t in Containers)
        {
            if (t == container)
            {
                Console.WriteLine("Serial number: " + t.SerialNum + "; Mass: " + t.Mass + "; Maximum playload: " + t.MaxPlayload + "; Height: " + t.Height + "; Weight: " + t.Weight + "; Depth: " + t.Depth);
                containerFound = true;
                break;
            }
        }
        if (!containerFound)
        {
            throw new Exception("There is no such container in the ship.");
        }
    }

    public string Cargo()
    {
        string cargo = "Cargo: ";
        foreach (var t in Containers)
        {
            cargo = cargo + t.SerialNum + " ";
        }

        return cargo;
    }
}