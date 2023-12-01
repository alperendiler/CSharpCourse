


class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer { Age=10,LastName="Diler",FirstName="Alperen",CustomerId=1};
        CustomerDal customerDal = new CustomerDal();
        customerDal.Add(customer);

    }
}

[ToTable("Customer")]
class Customer
{
    [RequiredProperty]
    public int CustomerId { get; set; }
    [RequiredProperty]
    public string FirstName { get; set; }
    [RequiredProperty]
    public string LastName { get; set; }
    [RequiredProperty]
    public int Age { get; set; }

}

class CustomerDal
{
    [Obsolete("Don't use Add, insteade use AddNew Method ")]
    public void Add(Customer customer)
    {
        Console.WriteLine("{2},{3},{1},{0}",customer.CustomerId,customer.Age,customer.FirstName,customer.LastName);
    }
    public void AddNew(Customer customer)
    {
        Console.WriteLine("{2},{3},{1},{0}", customer.CustomerId, customer.Age, customer.FirstName, customer.LastName);
    }
}

[AttributeUsage(AttributeTargets.Property,AllowMultiple =true )]
class RequiredPropertyAttribute: Attribute
{

}

[AttributeUsage(AttributeTargets.Class)]
class ToTableAttribute :Attribute
{
    private string _tableName;
    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}



