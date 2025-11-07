class Circle
{
    Point center;
    double radius;
    public Circle()
    {
        Point p = new Point();
    }
    public Circle(Point center, double radius)
    {
        this.center = new Point(center.X, center.Y);
        this.radius = radius;
    }
    public double Radius { get { return radius; } set { radius = value; } }
    public Point Center { get { return center; } set { center = value; } }
    public double CalculateCircumference()
    {
        double circumference = 2 * 3.14 * radius;
        return circumference;
    }
    public double CalculateArea()
    {
        double area = 3.14 * radius * radius;
        return area;
    }
}