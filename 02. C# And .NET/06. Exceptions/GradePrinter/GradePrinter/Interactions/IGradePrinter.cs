using GradePrinter.Models;

namespace GradePrinter.Interactions
{
    public interface IGradePrinter
    {
        void Print(List<Student> students);
    }
}