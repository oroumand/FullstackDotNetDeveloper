using GradePrinter.Interactions;
using GradePrinter.Models;
using System.Text.Json;

public class StudentJsonDataDeserializer : IStudentDataDeserializer
{
    private readonly IUserInteractor userInteractor;

    public StudentJsonDataDeserializer(IUserInteractor userInteractor)
    {
        this.userInteractor = userInteractor;
    }
    public List<Student> Deserialize(string filePath, string fileContent)
    {
        try
        {
            return JsonSerializer.Deserialize<List<Student>>(fileContent);
        }
        catch (JsonException ex)
        {
            userInteractor.PrintMessage($"The content of file {filePath} is not valid.");
            throw new JsonException($"{ex.Message} File name is: {filePath}", ex);
        }
    }
}

