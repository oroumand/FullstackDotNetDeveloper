namespace SRP;

public class ListStringRepository
{
    public void Save(List<string> Input, string path)
    {
        File.WriteAllLines(path, Input);
    }

    public List<string> GetLineStrings(string path)
    {
        var lines = File.ReadAllLines(path).ToList();
        return lines;
    }
}
