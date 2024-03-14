namespace GuessNumberGame;

public static class ConsoleReader
{

    public static bool TryReadInt(string message, out int value)
    {
        Console.Write(message);
        return int.TryParse(Console.ReadLine(), out value);
    }
}