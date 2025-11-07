class HourlyEmplyee : Employee
{
    double hours;
    double hourePrice;
    public HourlyEmplyee() : base() { }
    public HourlyEmplyee(string name, int number, double hours, double hourePrice) : base(name, number)
    {
        this.Hour = hours;
        this.HourePrice = hourePrice;
    }

    public double Hour { get => hours; set => hours = value; }
    public double HourePrice { get => hourePrice; set => hourePrice = value; }
    public override double GetPaymentAmount()
    {
        return hours * hourePrice;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}