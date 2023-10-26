﻿
using Interfaces;

class program
{
    static void Main(string[] args)
    {
        //InterfacesIntro();

        //Demo2();

        ICustomerDal[] customerDals = new ICustomerDal[3]
        {new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }



    }

    private static void Demo2()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        manager.Add(new Customer { Id = 1, FirstName = "Alperen", LastName = "Diler", Address = "Isparta" });

        Student student = new Student();
        manager.Add(new Student { Id = 1, FirstName = "Mehmet", LastName = "Diler", Departmant = "PC" });
    }
}



interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }



}


class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }

}







