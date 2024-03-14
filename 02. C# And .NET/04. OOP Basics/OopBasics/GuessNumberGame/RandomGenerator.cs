namespace GuessNumberGame;
public class RandomGenerator(Random random, int minValue = 1, int maxValue = 10)
{
    private readonly Random _random = random;
    private readonly int _minValue = minValue;
    private readonly int _maxValue = maxValue;

    public int GetRandom()
    {
        return _random.Next(_minValue, _maxValue + 1);
    }
}
