abstract class Shape
{
    string name;
    int sideNumber;
    Point startPoint;
    public Shape()
    {
        startPoint = new Point();
    }
    public Shape(string name, int sideNumber, Point startPoint)
    {
        this.name = name;
        this.sideNumber = sideNumber;
        this.startPoint = new Point(startPoint.X, startPoint.Y);
    }
    public string Name { get { return name; } set { name = value; } }
    public int SideNumber { get { return sideNumber; } set { sideNumber = value; } }
    public Point StartPoint { get { return startPoint; } set { startPoint = value; } }
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}