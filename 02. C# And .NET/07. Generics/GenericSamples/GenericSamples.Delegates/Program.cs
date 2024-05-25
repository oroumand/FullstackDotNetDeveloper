
using System.Reflection.PortableExecutable;

MyVoidString first = PrintToUpper;
MyVoidString second = PrintToLower;
MyVoidString third = first + second;

third("Alireza");


Console.ReadLine();


string MyToUpper(string str)
{
    return str.ToUpper();
}


string MyToLower(string str)
{
    return str.ToLower();
}

void PrintToUpper(string input)
{
    Console.WriteLine(input.ToUpper());
}
void PrintToLower(string input)
{
    Console.WriteLine(input.ToLower());
}
delegate string MyStringStringDelegate(string param01);
delegate void MyVoidString(string param01);
