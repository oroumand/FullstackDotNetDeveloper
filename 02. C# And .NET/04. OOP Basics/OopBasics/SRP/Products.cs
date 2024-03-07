namespace SRP;
public class Products
{
    public List<string> ProductsList = [];

    public void AddProduct(string productName)
    {
        if (IsValidProductName(productName))
        {
            ProductsList.Add(productName);
        }
        else
        {
            Console.WriteLine("Invalid Product Name");
        }
    }

    public void AddProducts(List<string> products)
    {
        foreach (string productName in products)
        {
            AddProduct(productName);
        }
    }
    private bool IsValidProductName(string productName) =>
       !(string.IsNullOrEmpty(productName)) && productName.Length >= 2 && productName.Length <= 100;    
    
}
