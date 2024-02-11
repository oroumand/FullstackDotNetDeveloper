



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
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddToDo();
            break;
        case "R":
        case "r":
            RemovToDo();
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

void RemovToDo()
{
    bool isValidMessage = false;
    while (!isValidMessage)
    {
        Console.WriteLine();
        if (Todos.Count == 0)
        {
            Console.WriteLine("There is no todo.");
        }
        Console.WriteLine("Please select a todo number for remove.");

        SeeAllTodos();
        Console.Write("Selected index is: ");
        string inputIndex = Console.ReadLine();
        if (inputIndex == "")
        {
            Console.WriteLine("Invali index: index can not be empty.");
            continue;
        }

        if (int.TryParse(inputIndex, out int index))
        {
            if (index >= 1 && index <= Todos.Count)
            {
                isValidMessage = true;
                string todoForDelete = Todos[index - 1];
                Todos.RemoveAt(index - 1);
                Console.WriteLine($"Todo removed: {todoForDelete}");
            }
            else
            {
                Console.WriteLine("Invali index: index is not in correct range.");
            }
        }
        else
        {
            Console.WriteLine("Invali index: index format is invalid.");
        }
    }

}

void SeeAllTodos()
{
    Console.WriteLine();
    if (Todos.Count == 0)
    {
        Console.WriteLine("There is no todo.");
    }
    Console.WriteLine("Todo items are:");

    for (int i = 0; i < Todos.Count; i++)
    {
        string? item = Todos[i];
        Console.WriteLine($"{i + 1}: {item}");
    }

}

void AddToDo()
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