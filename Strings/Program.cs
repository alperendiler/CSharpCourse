class Program
{
    static void Main(string[] args)
    {
        // Intro();
        string sentence = "My name is Alperen Diler";

        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "My name is F";

        bool result3 = sentence.EndsWith("c");
        bool result4 = sentence.StartsWith("My Name");

        var result5 = sentence.IndexOf("name");
        var result6 = sentence.LastIndexOf(" ");
        var result7 = sentence.Insert(0, "hello");
        var result8 = sentence.Substring(3);
        var result9 = sentence.ToLower();
        var result10 = sentence.ToUpper();
        var result11 = sentence.Replace(" ", "-");
        var result12 = sentence.Remove(2);


        Console.WriteLine(result + "||" + result2 + "||" + result3 + "||" + result4 + "||" +
            result5 + "||" + result6 + "||" + result7 + "||" + result8 + "||" + result9
            + "||" + result10 + "||" + result11 + "||" + result12);




    }

    private static void Intro()
    {
        string city = "Isparta";
        Console.WriteLine(city);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "Antalya ";
        string result = city + " " + city2;
        Console.WriteLine(result);
        Console.WriteLine(String.Format("{0} {1}", city2, city));
    }
}