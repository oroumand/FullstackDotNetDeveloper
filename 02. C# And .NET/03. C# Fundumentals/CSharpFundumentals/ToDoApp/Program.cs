
Console.WriteLine("[S]ee All Todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit todo app");
string userInput = Console.ReadLine();
if (userInput == "S")
{
    PrintMessage("See All todos");
}
else if (userInput == "A")
{
    PrintMessage("Add a todo");
}
else if (userInput == "R")
{
    PrintMessage("Remove a todo");
}
else if (userInput == "E")
{
    PrintMessage("Exit todo app");
}



Console.ReadLine();

void PrintMessage(string userInputMessage)
{
    Console.WriteLine("User Select: " + userInputMessage);
}


