namespace GradePrinter.Interactions
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public string GetValidFilePath()
        {
            bool isValidFilePath = false;
            string filePath;
            do
            {

                Console.Write("Please Enter the file name:");
                filePath = Console.ReadLine();
                if (string.IsNullOrEmpty(filePath))
                {
                    Console.WriteLine("The file name can not be null or empty");
                }
                else if (!File.Exists(filePath))
                {
                    Console.WriteLine("The file dose not exists");

                }
                else
                {

                    isValidFilePath = true;
                }
            } while (!isValidFilePath);
            return filePath;
        }

        public void PrintError(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
