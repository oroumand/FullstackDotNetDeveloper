using ExceptionSamples.ThrowEx;

Person person = new("", -100);
Console.Write("Pleas get age:");
string message = Console.ReadLine();
try
{
    int age = ConvertStringToInt(message);
    int divided = 100 / age;
    Console.WriteLine(age);
    Console.WriteLine(divided);
}

catch (FormatException ex)
{
    Console.WriteLine($"Invalid Format Exception");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Divided by zero");
}
catch (Exception ex)
{
    Console.WriteLine("Unknown..");
}
finally
{
    Console.WriteLine("Finish...");
}
Console.ReadLine();


int ConvertStringToInt(string str)
{
    try
    {
        return Convert.ToInt32(str);

    }
    catch (Exception)
    {
        Console.WriteLine("Invalid Input String");
        throw new FormatException("Yout input string was incorrect.")
    }

}