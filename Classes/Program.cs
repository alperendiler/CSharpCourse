using Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Uptade();
        

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Uptade();


        Customer customer = new Customer();
        customer.City = "Isparta";
        customer.Id = 1;
        customer.FirstName = "Alperen";
        customer.LastName = "Diler";

        Customer customer2 = new Customer
        {
            Id = 2,
            City= "İstanbul",
            FirstName = "Mehmet",
            LastName = "Bayır"
            
        }; 

        Console.WriteLine(customer2.FirstName);



    }


}


