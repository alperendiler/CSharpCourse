
class Program
{
    static void Main(string[] args)
    {
        List<string> city = new List<string>();
        city.Add("Isparta");
        Console.WriteLine(city.Count);
        
        MyList<string> city2 = new MyList<string>();

        city2.Add("Bursa");
        city2.Add("Bursa");
        city2.Add("Bursa");

        Console.WriteLine(city2.Count);

    }
}


class MyList<T> //Generic Class
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length+1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }

        _array[_array.Length-1] = item;
    }


    public int Count
    {
        get { return _array.Length; }
    }

}



























