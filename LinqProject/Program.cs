

class Program
{
    static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Teknoloji"},
            new Category{CategoryId=2,CategoryName="Sağlık"}

        };
        List<Product> products = new List<Product> { 
            new Product { ProductId = 1, CategoryId= 2, ProductName = "Parol" ,UnitPrice = 10, UnitsInStock = 44 },
            new Product { ProductId = 2, CategoryId= 1, ProductName = "Samsung Kulaklık" ,UnitPrice = 222, UnitsInStock = 14 },
             new Product { ProductId = 3, CategoryId= 1, ProductName = "Oppo Kulaklık" ,UnitPrice = 323, UnitsInStock = 22 },
              new Product { ProductId = 4, CategoryId= 2, ProductName = "Gaviscon" ,UnitPrice = 23, UnitsInStock = 55 },
               new Product { ProductId = 5, CategoryId= 1, ProductName = "Razer Klavye" ,UnitPrice = 123, UnitsInStock = 0 },


        };
        Console.WriteLine("----------------Algoritmik--------------------");
        foreach (var product in products) 
        {
            if (product.UnitPrice > 100 && product.UnitsInStock >15)
            {
                Console.WriteLine(product.ProductName);

            }
        }
        
        Console.WriteLine("----------------Linq--------------------");

        var result = products.Where(p => p.UnitPrice > 100 && p.UnitsInStock > 15);

        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }
        GetProducts(products);
        GetProductsLinq(products);
        Console.WriteLine(GetProductsLinq);
    }

    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filterProducts = new List<Product>();
        foreach (var product in products)
        {
            if (product.UnitPrice > 100 && product.UnitsInStock > 15)
            {
                filterProducts.Add(product);



            }
        }
        return filterProducts;
    }
    static List<Product> GetProductsLinq(List<Product> products)
    {
        return products.Where(p => p.UnitPrice > 100 && p.UnitsInStock > 15).ToList() ;

    }
}


class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}




























