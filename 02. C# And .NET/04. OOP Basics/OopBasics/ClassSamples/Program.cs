Console.WriteLine("Hello, World!");
Rectangle rectangle = new(10, 20);

Console.WriteLine(rectangle.CalculateArea());
Console.ReadLine();

public class Rectangle
{
    public int _width = 3;
    public int _height = 5;
    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public int CalculateArea()
    {
        return _width * _height;
    }

    public void SetHeight(int newHeight)
    {
        if (newHeight < 0)
            throw new ArgumentException("Invalid new hight");
        _height = newHeight;
    }
}


public class RectangleCalculator
{
    public int CalculateArea(Rectangle rectangle)
    {
        return rectangle._width * rectangle._height;
    }
}
