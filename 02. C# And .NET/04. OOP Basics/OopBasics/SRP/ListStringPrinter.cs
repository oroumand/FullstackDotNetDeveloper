namespace SRP;

public class ListStringPrinter()
{
    public void Print(List<string> input)
    {
        string productFormated = string.Join(", ", input);
        Console.WriteLine(productFormated);
    }
}
