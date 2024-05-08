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
catch(DivideByZeroException ex)
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
    return Convert.ToInt32(str);

}