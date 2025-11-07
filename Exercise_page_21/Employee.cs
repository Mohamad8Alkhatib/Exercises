abstract class Employee : IPayable
{
    string name;
    int number;
    public Employee() { }
    public Employee(string name, int number)
    {
        this.name = name;
        this.number = number;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Number
    {
        get { return number; }
        set { number = value; }
    }
    public abstract double GetPaymentAmount();
    public override string ToString()
    {
        return $"Employee Name: {name}\nEmployee Number: {number}\nEmployee Salary: {GetPaymentAmount()}";
    }
}