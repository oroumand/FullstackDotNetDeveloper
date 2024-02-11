

Console.WriteLine("Hello. Wellcome to Todo App. Pleas select an option.");
bool isExitSelected = false;
List<string> Todos = [];

while (!isExitSelected)
{
    Console.WriteLine();
    Console.WriteLine("[S]ee all todos.");
    Console.WriteLine("[A]dd a todo.");
    Console.WriteLine("[R]emove a todo.");
    Console.WriteLine("[E]xit");

    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "S":
        case "s":
            Console.WriteLine("See all todos");
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove a todo");
            break;
        case "E":
        case "e":
            isExitSelected = true;
            break;
        default:
            Console.WriteLine("Invalid input.Please select a correct option.");
            break;
    }
}



void AddTodo()
{
    bool isValidMessage = false;
    while (!isValidMessage)
    {
        Console.WriteLine();
        Console.Write("Plese enter the todo message:");
        string inputMessage = Console.ReadLine();
        if (inputMessage == "")
        {
            Console.WriteLine("Invali message: message can not be empty.");
        }
        else if (Todos.Contains(inputMessage))
        {
            Console.WriteLine("Invali message: message can not be duplicate.");
        }
        else
        {
            isValidMessage = true;
            Todos.Add(inputMessage);
        }
    }
}