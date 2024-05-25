using GenericSamples.DictionarySamples;

List<Student> students = [];
students.Add(new Student("Alireza", "Oroumand", "st001", "Aval", 11));
students.Add(new Student("Alireza", "Oroumand", "st002", "Dovom", 15));
students.Add(new Student("Alireza", "Oroumand", "st003", "Sevom", 19));
students.Add(new Student("Alireza", "Oroumand", "st004", "Sevom", 18));
students.Add(new Student("Alireza", "Oroumand", "st005", "Sevom", 11));
students.Add(new Student("Alireza", "Oroumand", "st006", "Dovom", 9));
students.Add(new Student("Alireza", "Oroumand", "st007", "Aval", 13));
students.Add(new Student("Alireza", "Oroumand", "st008", "Aval", 15));

var result = CalculateAvrages(students);
var bgSelector = new BackgroundSelector();
string color = Console.ReadLine();
var Selected = bgSelector.Get(color);
ResultPrinter(result, Selected);
Console.ReadLine();


List<KeyValuePair<string, int>> CalculateAvrages(List<Student> students)
{
    Dictionary<string, List<Student>> keyValuePairs = new Dictionary<string, List<Student>>();
    List<KeyValuePair<string, int>> result = [];
    foreach (var item in students)
    {
        if (!keyValuePairs.ContainsKey(item.Maghta))
        {
            keyValuePairs.Add(item.Maghta, new List<Student>());
        }

        keyValuePairs[item.Maghta].Add(item);
    }

    foreach (var item in keyValuePairs)
    {
        int sumAvg = 0;
        foreach (var studnt in item.Value)
        {
            sumAvg += studnt.Avg;
        }
        int totalAvg = sumAvg / item.Value.Count;
        //Console.WriteLine($"{item.Key}: {totalAvg}, count: {item.Value.Count}");

        result.Add(new KeyValuePair<string, int>(item.Key, totalAvg));
    }
    return result;
}

void ResultPrinter(List<KeyValuePair<string, int>> input, IBackgroundSelector backgroundSelector)
{
    backgroundSelector.SetColor();
    foreach (var item in input)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}


public interface IBackgroundSelector
{
    void SetColor();
}

public class SetToGreen : IBackgroundSelector
{
    public void SetColor()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
}

public class SetToRED : IBackgroundSelector
{
    public void SetColor()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
}

public class SetToBlue : IBackgroundSelector
{
    public void SetColor()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
}
public class SetToYellow : IBackgroundSelector
{
    public void SetColor()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}
public class SetToCyan : IBackgroundSelector
{
    public void SetColor()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
}

public class BackgroundSelector
{
    Dictionary<string, IBackgroundSelector> items = [];
    public BackgroundSelector()
    {
        items["RED"] = new SetToRED();
        items["BLUE"] = new SetToBlue();
        items["GREEB"] = new SetToGreen();
        items["YELLOW"] = new SetToYellow();
        items["Cyan"] = new SetToCyan();

        Console.WriteLine($"Select Color({string.Join(',', items.Keys)}):");

    }
    public IBackgroundSelector Get(string key) => items[key];
}