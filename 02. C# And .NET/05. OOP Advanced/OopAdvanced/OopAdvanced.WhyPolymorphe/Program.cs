// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");


public class Basket
{
    List<Product> propducts = [];

    public void AddProduct(Product product)
    {
        propducts.Add(product);
    }

    public void PrintOnScreen()
    {
        foreach ( var product in propducts )
        {
            Console.WriteLine();
        }
    }

}
public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
}

public class Laptop: Product
{


    public int Hdd { get; set; }
    public int Ram { get; set; }
    public int MonitorSize { get; set; }
}

public class Book: Product
{
    public string Author { get; set; }
    public int PageCount { get; set; }
    public string ISBN { get; set; }
}

public class Car: Product
{
    public int WheelsCount  { get; set; }
    public int DoorCount { get; set; }
}