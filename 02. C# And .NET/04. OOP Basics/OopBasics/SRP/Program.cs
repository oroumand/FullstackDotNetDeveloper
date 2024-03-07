using SRP;

Products products = new();
ListStringPrinter listStringPrinter = new ListStringPrinter();
FilePathBuilder filePathBuilder = new FilePathBuilder();
ListStringRepository productsRepository = new ListStringRepository();

bool fileExists = File.Exists(filePathBuilder.GetFileName());

if (!fileExists)
{
    Console.Write("There is no file. Get the number of products: ");
    int productCount = int.Parse(Console.ReadLine());

    for (int i = 0; i < productCount; i++)
    {
        Console.Write($"Please get name of {i + 1} product:");
        products.AddProduct(Console.ReadLine());
    }
    productsRepository.Save(products.ProductsList, filePathBuilder.GetFileName());
}
else
{
    var productNames = productsRepository.GetLineStrings(filePathBuilder.GetFileName());
    products.AddProducts(productNames);
    listStringPrinter.Print(products.ProductsList);
}

Console.WriteLine("Finished!");
Console.ReadLine();