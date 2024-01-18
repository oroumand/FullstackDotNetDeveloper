int num01 = GetNumber("first");
int num02 = GetNumber("seccond"); ;

Console.WriteLine("Select your oprator");
Console.WriteLine("[A]dd: A or a or +");
Console.WriteLine("[S]ubtract: S or s or -");
Console.WriteLine("[M]ultiply: M or m or *");
string oprator = Console.ReadLine();

if(oprator=="+" || oprator == "A" || oprator=="a")
{
    PrintResultMessage(num01, num01, "+", num01 + num02);
}
else if(oprator == "-" || oprator == "S" || oprator == "s")
{
    PrintResultMessage(num01, num01, "-", num01 - num02);
}
else if(oprator == "*" || oprator == "M" || oprator == "m")
{
    PrintResultMessage(num01, num01, "*", num01 * num02);
}

Console.ReadLine();

int GetNumber(string numberOrder)
{
    Console.Write("Pleas enter "+numberOrder+" number: ");
    return int.Parse(Console.ReadLine());

}

void PrintResultMessage(int num1, int num2, string opeator, int result)
{
    Console.WriteLine($"{num1} {opeator} {num2} = {result}");
}