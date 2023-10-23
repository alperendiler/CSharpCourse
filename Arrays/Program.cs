class Program
{
    static void Main(string[] args)
    {
        string[] students = new string[3];

        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";

        string[] students2 = new string[3] { "engin", "derin", "salih" };


        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }


        string[,] regions = new string[5, 3]
        {
            {"İstanbul","Edirne","Bursa" },
            {"İzmir","Muğla","Aydın" },
            {"Isparta","Antalya","Adana" },
            {"Ankara","Konya","Kırıkkale" },
            {"Rize","Trabzon","Samsun" }


        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int J = 0; J <= regions.GetUpperBound(1); J++)
            {
                Console.WriteLine(regions[i,J]);   
            }
            Console.WriteLine("**************");
        }

        //regions[0, 0] = "İstanbul";


    }







}
