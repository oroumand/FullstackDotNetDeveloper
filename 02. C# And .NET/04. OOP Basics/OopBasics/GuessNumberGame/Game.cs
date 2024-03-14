namespace GuessNumberGame;

public class Game(RandomGenerator randomGenerator, int maxGuessCount = 3)
{
    private int _randomNumber = randomGenerator.GetRandom();
    private int _maxGuessCount = maxGuessCount;

    public GameResult Play()
    {
        int guessCount = 0;
        GameResult gameResult = GameResult.Lost;

        while (guessCount < _maxGuessCount)
        {
            guessCount++;

            if (!ConsoleReader.TryReadInt("Pleas enter a valid number:", out int value))
            {
                Console.WriteLine("Invalid Number.");
                continue;
            }

            if (value == _randomNumber)
            {
                gameResult =  GameResult.Win;
                break;
            }


        }
        return gameResult;

    }
    public static void PrintResultMessage(GameResult result)
    {
        string message = result == GameResult.Win ?
            "You Win the game" :
            "You Lost the game";
        Console.WriteLine(message);
    }
}
