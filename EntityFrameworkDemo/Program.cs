

using EntityFrameworkDemo;

//GetAll();

GetProductsByCategory(1);
static void GetProductsByCategory(int id)
{
    NorthwindContext northwindContext = new NorthwindContext();

    var result = northwindContext.Products.Where(p => p.CategoryId == id);

    foreach (var product in result)
    {
        Console.WriteLine(product.ProductName);
    }
}
static void GetAll()
{
    NorthwindContext northwindContext = new NorthwindContext();

    foreach (var product in northwindContext.Products)
    {
        Console.WriteLine(product.ProductName);
    }
}

