using GradePrinter.Interactions;
using GradePrinter.Models;

namespace GradePrinter.App
{
    public class GradePrinterService
    {
        private readonly IUserInteractor userInteractor;
        private readonly IGradePrinter gradePrinter;
        private readonly IStudentDataDeserializer studentDataDeserializer;

        public GradePrinterService(IUserInteractor userInteractor, IGradePrinter gradePrinter, IStudentDataDeserializer studentDataDeserializer)
        {
            this.userInteractor = userInteractor;
            this.gradePrinter = gradePrinter;
            this.studentDataDeserializer = studentDataDeserializer;
        }

        public void Execute()
        {
            string filePath = userInteractor.GetValidFilePath();
            string fileContent = File.ReadAllText(filePath);
            List<Student> students = studentDataDeserializer.Deserialize(filePath, fileContent);
            gradePrinter.Print(students);
        }
    }
}

