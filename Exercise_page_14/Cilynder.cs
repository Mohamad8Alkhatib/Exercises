class Cilynder
{
    Circle baseCircle;
    double height;
    public Cilynder()
    {
        Circle c = new Circle();
    }
    public Cilynder(Circle baseCircle, double height)
    {
        this.baseCircle = new Circle(baseCircle.Center, baseCircle.Radius);
        this.height = height;
    }
    public double Height { get { return height; } set { height = value; } }
    public Circle BaseCircle { get { return baseCircle; } set { baseCircle = value; } }
    public double CalculateVolume()
    {
        double volume = baseCircle.CalculateArea() * height;
        return volume;
    }
}