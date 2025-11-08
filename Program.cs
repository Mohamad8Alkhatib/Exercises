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
Console.WriteLine("Cylinder Volume: " + volume);
*/
/*
// Exercise page 16:
Console.WriteLine("Enter Shape name:");
string name = Console.ReadLine();
Console.WriteLine("Enter number of sides:");
int sideNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Start Point coordinates:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Point startPoint = new Point(x, y);
Console.WriteLine("Enter Square side length:");
double sideLength = Convert.ToDouble(Console.ReadLine());
Square square = new Square(name, sideNumber, startPoint, sideLength);
Console.WriteLine("Square Area: " + square.CalculateArea());
Console.WriteLine("Square Perimeter: " + square.CalculatePerimeter());
*/
/*
//Exercise page 21:
IPayable[] payables = new IPayable[3];
payables[0] = new SalariedEmployee("Ahmad", 1, 3000);
payables[1] = new HourlyEmplyee("Omar", 2, 4, 300);
payables[2] = new Invoice(12, 3, 20, "Parts");
foreach (IPayable payable in payables)
{
    Console.WriteLine(payable.ToString());
}
*/
/*
// Example about marker interface:
Player player = new Player("Alice", 5);
GameSettings settings = new GameSettings(true, 2);
SaveHelper.SaveObject(player);
SaveHelper.SaveObject(settings);
*/
/*
// Example page 35 about exception
try
{
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int z = x / y;
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Done");
}
*/
/*
//Exercise page 37
try
{
    Console.WriteLine("Enter array1 size:");
    int size1 = int.Parse(Console.ReadLine());
    int[] arr1 = new int[size1];
    Console.WriteLine("Enter array2 size:");
    int size2 = int.Parse(Console.ReadLine());
    int[] arr2 = new int[size2];
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine($"Enter number{i + 1} for array1:");
        arr1[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.WriteLine($"Enter number{i + 1} for array2:");
        arr2[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine($"arr1[{i}] / arr2[{i}] = {arr1[i] / arr2[i]}");
    }
}
catch (FormatException e)
{
    Console.WriteLine("Please Enter an int number");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Can't divide by zero");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Array index is out of range");
}
catch (OverflowException e)
{
    Console.WriteLine("Please enter a smaller number");
}
catch (Exception e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}
*/
