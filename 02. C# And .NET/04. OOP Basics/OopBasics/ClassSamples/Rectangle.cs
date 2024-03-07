
public class Rectangle
{
    int _width = 3;
    int _height = 5;
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
