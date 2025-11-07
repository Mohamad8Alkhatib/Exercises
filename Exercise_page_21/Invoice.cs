class Invoice : IPayable
{
    int invoiceNumber;
    int count;
    double price;
    string attribute;
    public Invoice() { }
    public Invoice(int invoiceNumber, int count, double price, string attribute)
    {
        this.invoiceNumber = invoiceNumber;
        this.count = count;
        this.price = price;
        this.attribute = attribute;
    }
    public int InvoiceNumber { get => invoiceNumber; set => invoiceNumber = value; }

    public int Count { get => count; set => count = value; }

    public double Price { get => price; set => price = value; }

    public string Attribute { get => attribute; set => attribute = value; }
    public double GetPaymentAmount()
    {
        return price * count;
    }
    public override string ToString()
    {
        return $"Invoice Number: {invoiceNumber}\nCount: {count}\nPrice: {price}\nAttribute: {attribute}\nTotal Payment: {GetPaymentAmount()}";
    }
}