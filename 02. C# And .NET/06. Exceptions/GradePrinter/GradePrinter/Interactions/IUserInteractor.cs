namespace GradePrinter.Interactions
{
    public interface IUserInteractor
    {

        void PrintMessage(string message);
        void PrintError(string message);
        string GetValidFilePath();
    }
}
