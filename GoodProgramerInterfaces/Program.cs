



class Program
{
    //Interface new'lenemez
    static void Main(string[] args)
    {
        //IPersonManager customerManager = new CustomerManager();
        //customerManager.Add();

        //IPersonManager employeeManager = new EmployeeManager();
        //employeeManager.Update();

        ProjectManager projectManager = new ProjectManager();
        projectManager.Add(new CustomerManager());
        projectManager.Update(new CustomerManager());

        projectManager.Add(new InternManager());
        projectManager.Update(new InternManager());

        projectManager.Add(new EmployeeManager());
        projectManager.Update(new EmployeeManager());
    }
}

interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();
}

//Inherits - Class ---------------------- Interfaces - Implement
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel Güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
    public void Update(IPersonManager personManager)
    {
        personManager.Update();
    }

}








