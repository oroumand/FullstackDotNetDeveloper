// See https://aka.ms/new-console-template for more information
public sealed class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public void Print()
    {
        Console.WriteLine($"{Id} {Name}");
    }
}