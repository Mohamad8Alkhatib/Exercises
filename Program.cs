// See https://aka.ms/new-console-template for more information
/*
// Exercise page 14:
Console.WriteLine("Enter Point coordinates:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Point center = new Point(x, y);
Console.WriteLine("Enter Circle radius:");
double radius = Convert.ToDouble(Console.ReadLine());
Circle circle = new Circle(center, radius);
Console.WriteLine("Circle Area: " + circle.CalculateArea());
Console.WriteLine("Enter Cylinder height:");
double height = Convert.ToDouble(Console.ReadLine());
Cilynder cylinder = new Cilynder(circle, height);
double volume = cylinder.CalculateVolume();
Console.WriteLine("Cylinder Volume: " + volume);*/
/*// Exercise page 16:
Console.WriteLine("Enter Shape name:");
string name = Console.ReadLine();
Console.WriteLine("Enter number of sides:");
int sideNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter Start Point coordinates:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Point startPoint = new Point(x, y);
Console.WriteLine("Enter Square side length:");
double sideLength = Convert.ToDouble(Console.ReadLine());
Square square = new Square(name, sideNumber, startPoint, sideLength);
Console.WriteLine("Square Area: " + square.CalculateArea());
Console.WriteLine("Square Perimeter: " + square.CalculatePerimeter());*/
/*//Exercise page 21:
IPayable[] payables = new IPayable[3];
payables[0] = new SalariedEmployee("Ahmad", 1, 3000);
payables[1] = new HourlyEmplyee("Omar", 2, 4, 300);
payables[2] = new Invoice(12, 3, 20, "Parts");
foreach (IPayable payable in payables)
{
    System.Console.WriteLine(payable.ToString());
}*/
// Example about marker interface:
Player player = new Player("Alice", 5);
GameSettings settings = new GameSettings(true, 2);
SaveHelper.SaveObject(player);
SaveHelper.SaveObject(settings);