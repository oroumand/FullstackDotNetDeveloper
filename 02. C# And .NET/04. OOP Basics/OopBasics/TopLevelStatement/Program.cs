namespace TopLevelStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


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

}
