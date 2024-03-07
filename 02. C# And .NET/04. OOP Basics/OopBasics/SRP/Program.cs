using SRP;

Products products = new();

bool fileExists = File.Exists(products.GetFileName());

if (!fileExists)
{
    Console.Write("There is no file. Get the number of products: ");
    int productCount = int.Parse(Console.ReadLine());

    for (int i = 0; i < productCount; i++)
    {
        Console.Write($"Please get name of {i + 1} product:");
        products.AddProduct(Console.ReadLine());
    }
    products.Save();
}
else
{
    products.Load();
    products.PrintProductNames();
}

Console.WriteLine("Finished!");
Console.ReadLine();