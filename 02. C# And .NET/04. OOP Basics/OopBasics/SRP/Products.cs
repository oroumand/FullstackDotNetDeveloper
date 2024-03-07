namespace SRP;
public class Products
{
    private List<string> products = new();

    public void AddProduct(string productName)
    {
        if (IsValidProductName(productName))
        {
            products.Add(productName);
        }
        else
        {
            Console.WriteLine("Invalid Product Name");
        }
    }

    private bool IsValidProductName(string productName) =>
       !(string.IsNullOrEmpty(productName)) && productName.Length >= 2 && productName.Length <= 100;

    public void Save()
    {
        File.WriteAllLines(GetFileName(), products);
    }

    public void Load()
    {
        var lines = File.ReadAllLines(GetFileName());
        foreach (var line in lines)
        {
            AddProduct(line);
        }
    }

    public void PrintProductNames()
    {
        string productFormated = string.Join(", ", products);
        Console.WriteLine(productFormated);
    }

    public string GetFileName() => "productNames.txt";
}
