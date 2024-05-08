// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
throw new MyException();
throw new Exception();


public class MyException : Exception
{
    public string MyUserName { get; set; }
    public MyException()
    {

    }
    public MyException(string myUserName,string? message):base(message)
    {
        
    }

    public MyException(string myUserName, string? message,Exception innerException) : base(message, innerException)
    {

    }
    public MyException(string? message) : base(message) { }

    public MyException(string? message, Exception innerException) :
        base(message, innerException)
    {

    }
}