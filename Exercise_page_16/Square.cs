class Square : Shape
{
    double sideLength;
    public Square() : base() { }
    public Square(string name, int sideNumber, Point startPoint, double sideLength) : base(name, sideNumber, startPoint)
    {
        this.sideLength = sideLength;
    }
    public double SideLength { get { return sideLength; } set { sideLength = value; } }
    public override double CalculateArea()
    {
        return sideLength * sideLength;
    }
    public override double CalculatePerimeter()
    {
        return 4 * sideLength;
    }
}