string message = "";
try
{
    Console.Write("Enter your age");
    message = Console.ReadLine();
    int age = int.Parse(message);
    Console.WriteLine(age);
    Console.ReadLine();
}
catch (Exception ex) when(string.IsNullOrEmpty(message))
{
    Console.WriteLine("the message is empty");

}
catch (Exception ex)
{
    Console.WriteLine("Invalid Input");

}
finally
{
    Console.ReadLine() ;
}