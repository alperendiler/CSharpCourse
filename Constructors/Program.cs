


class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer {CustomerId = 1 , FirstName ="Alperen",LastName="Diler",City="Isparta" };
        Customer customer2 = new Customer();
        Customer customer3 = new Customer(3,"Alperen","Diler","Aydın");
        customer2.CustomerId = 2;
        customer2.FirstName = "Alperen";
        customer2.LastName = "Diler";
        customer2.City = "İstanbul";


        Console.WriteLine(customer3.City);
    }


    
}

class Customer
{
    public Customer(int customerId, string firstName,string lastName, string city)
    {
        Console.WriteLine("Yapıcı blok çalıştı");
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        City = city;    

    }
    //default constructor
    public Customer()
    {
        
    }

    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }



}












