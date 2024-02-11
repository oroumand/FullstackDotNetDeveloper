Console.WriteLine("Hello. Wellcome to Todo App. Pleas select an option.");
bool isExitSelected = false;
List<string> todos = [];

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

void SeeAllTodos()
{
    if (!AllowContinue())
        return;

    WriteWithWhiteSpace("Todo items are:");

    for (int i = 0; i < todos.Count; i++)
    {
        string? item = todos[i];
        Console.WriteLine($"{i + 1}: {item}");
    }
}
void AddToDo()
{
    string inputMessage = string.Empty;
    do
    {
        WriteWithWhiteSpace("Plese enter the todo message:");
        inputMessage = Console.ReadLine();
    } while (IsValidMessage(inputMessage));
    todos.Add(inputMessage);
}

bool IsValidMessage(string message)
{
    bool isValid = true;
    if (message == "")
    {
        Console.WriteLine("Invali message: message can not be empty.");
        isValid = false;
    }
    else if (todos.Contains(message))
    {

        Console.WriteLine("Invali message: message can not be duplicate.");
        isValid = false;

    }
    return isValid;
}
void RemovToDo()
{
    if (!AllowContinue())
    {
        return;
    }

    bool isValidMessage = false;
    while (!isValidMessage)
    {
        WriteWithWhiteSpace("Please select a todo number for remove.");

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
            if (index >= 1 && index <= todos.Count)
            {
                isValidMessage = true;
                string todoForDelete = todos[index - 1];
                todos.RemoveAt(index - 1);
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
bool AllowContinue()
{
    if (todos.Count == 0)
    {
        WriteWithWhiteSpace("There is no todo.");
        return false;
    }
    return true;
}
void WriteWithWhiteSpace(string text)
{
    Console.WriteLine();
    Console.Write(text);
}

