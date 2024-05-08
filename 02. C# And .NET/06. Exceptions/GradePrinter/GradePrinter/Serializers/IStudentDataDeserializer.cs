using GradePrinter.Models;

public interface IStudentDataDeserializer
{
    List<Student> Deserialize(string filePath, string fileContent);
}