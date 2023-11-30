

// Void olan parametre almayan operasyonlara delegelik yapar
public delegate void MyDelegate();
public delegate void MyDelegate2(string text);
public delegate int MyDelegate3(int number1, int number2);


public class program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        //customerManager.SendMessage();
        //customerManager.ShowAlert();
        Matematik matematik = new Matematik();

        MyDelegate myDelegate = customerManager.SendMessage;
        myDelegate += customerManager.ShowAlert;
        if (myDelegate != null)
        {
            myDelegate -= customerManager.SendMessage;

        }

        MyDelegate2 myDelegate2 = customerManager.SendMessage2;
        myDelegate2 += customerManager.ShowAlert2;

        MyDelegate3 myDelegate3 = matematik.Add;
        myDelegate3 += matematik.Multipliy;


        Console.WriteLine(myDelegate3(5, 7));
        myDelegate2("asda");
        myDelegate();
    }
}

public class CustomerManager
{
    public void SendMessage()
    {
        Console.WriteLine("Hello");
    }
    public void ShowAlert()
    {
        Console.WriteLine("Be Carefull");
    }
    public void SendMessage2(string message)
    {
        Console.WriteLine(message);
    }
    public void ShowAlert2(string alert)
    {
        Console.WriteLine(alert);
    }


}
public class Matematik
{
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }
    public int Multipliy(int number1, int number2)
    {
        return number1 * number2;
    }

}










