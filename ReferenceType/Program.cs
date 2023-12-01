class Program
{
    static void Main(string[] args)
    {
    //    // Value Type Example
    //    int number1 = 10;
    //    int number2 = 60;
    //    number1 = number2;
    //    number2 = 50;

    //    Console.WriteLine(number1);

    //    // Referance Type Example
    //    int[] numbers1 = new int[3] { 77, 54, 89 };
    //    int[] numbers2 = new int[3] { 37, 44, 59 };
    //    numbers1 = numbers2;
    //    numbers2[0] = 12;

    //    Console.WriteLine(numbers1[0]);



        Person person1 =new Person();
        Person person2 =new Person();
        person1.FirstName = "Alperen";
        person2 = person1;
        person1.FirstName = "Mehmet";


        Console.WriteLine(person2.FirstName);


        Customer customer = new Customer();
        customer.FirstName = "Salih";
        customer.CreditCardNumber = "1231231231";

        Employee employee = new Employee();
        employee.FirstName = "Yasin";


        Person person3 = customer;
        customer.FirstName = "Ahmet";

        Console.WriteLine(((Customer)person3).CreditCardNumber);

        PersonManager personManager = new PersonManager();
        personManager.Add(customer);
        personManager.Add(employee);
        personManager.Add(person2);

    }



}
//base class
class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
class Customer : Person
{
    public string CreditCardNumber { get; set; }
}
class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}











