Console.Write("Pleas get age:");
string message = Console.ReadLine();
try
{
    int age = ConvertStringToInt(message);
    Console.WriteLine(age);
}
catch (Exception ex)
{
    Console.WriteLine($"Your input was incorrect. Message: {ex.Message}");
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

        Console.WriteLine($"Exception in {nameof(ConvertStringToInt)}");
        return 0;
    }
    //if (int.TryParse(str, out int result))
    //    return result;
    //return 0;
}