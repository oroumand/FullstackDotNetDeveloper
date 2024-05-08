using GradePrinter.Models;

namespace GradePrinter.Interactions
{
    public class StudentsGradePrinter : IGradePrinter
    {
        private readonly IUserInteractor userInteractor;

        public StudentsGradePrinter(IUserInteractor userInteractor)
        {
            this.userInteractor = userInteractor;
        }
        public void Print(List<Student> students)
        {
            if (students != null && students.Count > 0)
            {
                userInteractor.PrintMessage($"Find {students.Count} in file");
                foreach (Student student in students)
                    userInteractor.PrintMessage(student.ToString());
            }
            else
            {
                userInteractor.PrintMessage("There is no student data in file");
            }
        }
    }
}

