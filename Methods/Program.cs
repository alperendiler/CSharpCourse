class program
{
    static void Main(string[] args)
    {
       
        Add();
        int number1 = 20;
        int number2 = 120;
       
        var result = Add2(20, 22);
        Console.WriteLine(result);
        var result2 = Add3(10);
        Console.WriteLine(result2);
        var result3 = Add4(/*out */ref number1, number2);
        Console.WriteLine(result3 + "-" + number1);
        Console.WriteLine(Multiply(2,4));
        Console.WriteLine(Multiply(2, 4,5));
        Console.WriteLine(Add5(2,3,4,5,1));
    }


    static void Add()
    {
        Console.WriteLine("Added!");
    }


    static int Add2(int number1, int number2)
    {
        var result = number1 + number2;
        return result;
    }

    static int Add3(int number1, int number2 = 20)
    {
        var result = number1 + number2;
        return result;
    }

    static int Add4(/*out */ref int number1, int number2)
    {
        number1 = 30;
        var result = number1 + number2;
        return result;
    }


    static int Multiply(int number3, int number4)
    {
        return number3 * number4;
    }


    static int Multiply(int number3, int number4, int number5)
    {
        return number3 * number4 * number5;
    }

    static int Add5(params int[] numbers)
    {
        return numbers.Sum();
    }

}