using System.Reflection;

public class program
{
    static void Main(string[] args)
    {
        //    FourTransactions fourTransactions = new FourTransactions(2,3);

        //    Console.WriteLine(fourTransactions.Add(5, 2));
        //    Console.WriteLine(fourTransactions.Add2());

        var type = typeof(FourTransactions);

        //FourTransactions fourTransaction = (FourTransactions)Activator.CreateInstance(type,2,5);
        //Console.WriteLine(fourTransaction.Add(4, 5));
        //Console.WriteLine(fourTransaction.Add2());

        var instance = Activator.CreateInstance(type, 2, 5);
        // method bilgisi alınır 
        MethodInfo methodInfo = instance.GetType().GetMethod("Add2");
        // Invoke = getirdiğimiz metodu çalıştrımamızı sağlar
        Console.WriteLine(methodInfo.Invoke(instance, null));
        Console.WriteLine("-------------------------------");
        var methods = type.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine("Metod Adı : {0}", method.Name);
            foreach (var parameter in method.GetParameters())
            {
                Console.WriteLine("Parametre Adı : {0} ", parameter.ToString());
            }

            foreach (var attribute in method.GetCustomAttributes())
            {
                Console.WriteLine("Attribute Adı : {0}", attribute.GetType().Name);
            }
        }

    }
}

class MethodNameAttribute : Attribute
{
    public MethodNameAttribute(string name)
    {

    }
}


class FourTransactions
{
    private int _number1;
    private int _number2;
    public FourTransactions(int number1, int number2)
    {
        _number1 = number1;
        _number2 = number2;
    }

    public FourTransactions()
    {
    }

    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }
    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
    [MethodName("Toplama")]
    public int Add2()
    {
        return _number1 + _number2;
    }
    public int Multiply2()
    {
        return _number1 * _number2;
    }
}