// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Rectangle rectangle = new(10, 20);
rectangle.Print();


Console.ReadLine();
class Rectangle
{
    private int _width = 3;
    private int _height = 5;
    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public void Print()
    {
        Console.WriteLine($"Width:{_width}");
        Console.WriteLine($"Width:{_height}");
    }
}