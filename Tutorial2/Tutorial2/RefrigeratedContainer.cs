namespace Tutorial2;

public class RefrigeratedContainer: Container
{
    private Dictionary<Enum, double> _products;
    public Product TypeProduct;
    public double Temperature;
    private static int _count;
    
    public RefrigeratedContainer(double mass, double height, double weight, double depth, double maxPlayload, Product typeProduct) : base(mass, height, weight, depth, maxPlayload )
    {
        Mass = mass;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxPlayload = maxPlayload;
        SerialNum = CreatNum();
        _products = AddProducts();
        TypeProduct = typeProduct;
        Temperature = _products[TypeProduct];
    }
    
    private string CreatNum()
    {
        int id = _count;
        _count++;
        return "KON-C-" + id;
    }

    public Dictionary<Enum, double> AddProducts()
    {
        Dictionary<Enum, double> products = new Dictionary<Enum, double>();
        products.Add(Product.IceCream, -18);
        products.Add(Product.Bananas, 13.3);
        products.Add(Product.Chocolate, 18);
        products.Add(Product.Fish, 2);
        products.Add(Product.Meat, -15);
        products.Add(Product.FrozenPizza, -30);
        products.Add(Product.Cheese, 7.2);
        products.Add(Product.Sausages, 5);
        products.Add(Product.Butter, 20.5);
        products.Add(Product.Eggs, 19);
        return products;
    }

    public override void EmptyContainer()
    {
        Mass = 0;
    }

    public override void LoadContainer(double fillMass)
    {
        throw new NotImplementedException();
    } 
    
    public void LoadContainer(double fillMass, Product product)
    {
        if (TypeProduct == product)
        {
            if (Mass + fillMass <= MaxPlayload)
            {
                Mass += fillMass;
            }
            else
            {
                throw new OverfillException("An attempt to exceed the maximum capacity of container.");
            }
            
        }
        else
        {
            throw new Exception("This container can only store " + TypeProduct + ".");
        }
    }
}