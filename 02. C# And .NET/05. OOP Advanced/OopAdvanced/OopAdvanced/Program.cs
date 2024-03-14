// See https://aka.ms/new-console-template for more information
Product product1 = new Product();
product1.PrintPublic();
//product1.PrintProtected();
//product1.PrintPrivate();
Laptop laptop = new Laptop();
laptop.Count = 1;
Laptop laptop1 = new Laptop();
laptop1.Count = 2;
Console.WriteLine(laptop.Count);
Console.WriteLine(laptop1.Count);

Console.ReadLine();

public class Basket
{
    List<Product> propducts = [];

    public void AddProduct(Product product)
    {
        propducts.Add(product);
    }

    public void PrintOnScreen()
    {
        foreach (var product in propducts)
        {
            Console.WriteLine();
        }
    }

}
public class Product
{
    public int Count { get; set; }
    public void PrintPublic() => Console.WriteLine("Public method of Product");
    private void PrintPrivate() => Console.WriteLine("Private method of Product");
    protected void PrintProtected() => Console.WriteLine("Protected method of Product");
}

public class Laptop : Product
{
    public string Name => "Laptop";
    public string Description => "Laptop";
    public string ImageURL => "Laptop";

    public int Hdd { get; set; }
    public int Ram { get; set; }
    public int MonitorSize { get; set; }

    public void CallBaseMethods()
    {
        PrintPublic();
        // PrintPrivate();
        PrintProtected();
    }
}

public class Book : Product
{
    public string Name => "Book";
    public string Description => "Book";
    public string ImageURL => "Book";
    public string Author { get; set; }
    public int PageCount { get; set; }
    public string ISBN { get; set; }
}

public class Car : Product
{
    public string Name => "Car";
    public string Description => "Car";
    public string ImageURL => "Car";
    public int WheelsCount { get; set; }
    public int DoorCount { get; set; }
}