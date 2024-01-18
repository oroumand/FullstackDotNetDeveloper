
Console.WriteLine("[S]ee All Todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit todo app");
char userInput = Console.ReadKey().KeyChar;

switch (userInput)
{
    case 'S':
    case 's':
        PrintMessage("See All todos");
        break;
    case 'A':
    case 'a':
        PrintMessage("Add a todo");
        break;
    case 'R':
    case 'r':
        PrintMessage("Remove a todo");
        break;
    case 'E':
    case 'e':
        PrintMessage("Exit todo app");
        break;
    default:
        PrintMessage("Invalid character please try ageain!");
        break;
}


Console.ReadLine();

void PrintMessage(string userInputMessage)
{
    Console.WriteLine("User Select: " + userInputMessage);
}


