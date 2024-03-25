// See https://aka.ms/new-console-template for more information

using Tutorial2;

Console.WriteLine();
LiquidContainer container1 = new LiquidContainer(0, 100, 100, 100, 100, TypeLiquid.Fuel);
LiquidContainer container2 = new LiquidContainer(0, 200, 200, 200, 200, TypeLiquid.Milk);

Console.WriteLine();
container1.LoadContainer(48);
container2.LoadContainer(179);
Console.WriteLine(container1.SerialNum + " has mass " + container1.Mass);
Console.WriteLine(container2.SerialNum + " has mass " + container2.Mass);
container1.EmptyContainer();
Console.WriteLine(container1.SerialNum + " has new mass " + container1.Mass);

Console.WriteLine();
RefrigeratedContainer bananaContainer = new RefrigeratedContainer(0, 100, 100, 100, 100, Product.Bananas);
bananaContainer.LoadContainer(40, Product.Bananas);
Console.WriteLine(bananaContainer.SerialNum + " container has temperature " + bananaContainer.Temperature + " and product " + bananaContainer.TypeProduct + " and mass " + bananaContainer.Mass);

Console.WriteLine();
GasContainer gasContainer1 = new GasContainer(0, 100, 100,100, 100, 100);
GasContainer gasContainer2 = new GasContainer(0, 200, 200,200, 200, 200);
gasContainer1.LoadContainer(100);
gasContainer2.LoadContainer(150);
Console.WriteLine(gasContainer1.SerialNum + " has mass " + gasContainer1.Mass + " and pressure " + gasContainer1.Pressure);
gasContainer1.EmptyContainer();
Console.WriteLine(gasContainer1.SerialNum + " has new mass " + gasContainer1.Mass + " and pressure " + gasContainer1.Pressure);
Console.WriteLine(gasContainer2.SerialNum + " has mass " + gasContainer2.Mass + " and pressure " + gasContainer2.Pressure);

Console.WriteLine();
Ship ship1 = new Ship(100, 10, 300);
ship1.LoadContainer(container1);
ship1.LoadContainer(container2);
ship1.PrintContainer(container1);
ship1.PrintContainer(container2);

Console.WriteLine();
Ship ship2 = new Ship(200, 20, 400);
ship2.LoadContainer(bananaContainer);
ship2.LoadContainer(container2);
ship2.RemoveContainer(container2);
ship2.LoadContainer(gasContainer1);
ship2.PrintContainer(bananaContainer);
ship2.PrintContainer(gasContainer1);
ship2.ReplaceContainer("KON-G-0", gasContainer2);
ship2.PrintContainer(gasContainer2);

Console.WriteLine();
ShipManager shipManager = new ShipManager();
shipManager.PrintShip(ship1);
shipManager.PrintShip(ship2);
shipManager.TransferContainer(ship1, ship2, container1);
shipManager.PrintShip(ship1);
shipManager.PrintShip(ship2);

Console.WriteLine();
ship2.RemoveContainer(container1);
List<Container> listOfContainers = [gasContainer1, container1];
ship1.LoadContainerList(listOfContainers);
shipManager.PrintShip(ship1);
shipManager.PrintShip(ship2);