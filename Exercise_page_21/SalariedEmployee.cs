class SalariedEmployee : Employee
{
    double salary;
    public SalariedEmployee() : base() { }
    public SalariedEmployee(string name, int number, double salary) : base(name, number)
    {
        this.salary = salary;
    }
    public double Salary
    {
        get => salary;
        set
        {
            if (value < 0)
                System.Console.WriteLine("Error, try again");
            salary = value;
        }
    }
    public override double GetPaymentAmount()
    {
        return salary;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}