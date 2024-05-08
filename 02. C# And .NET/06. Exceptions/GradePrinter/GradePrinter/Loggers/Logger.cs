namespace GradePrinter.Loggers
{
    public class Logger
    {
        private readonly string fileName;

        public Logger(string fileName)
        {
            this.fileName = fileName;
        }
        public void LogError(Exception ex)
        {
            string msg = $@"
                DateTime: {DateTime.Now}
                Message: {ex.Message}
                StackTrace: {ex.StackTrace}
                {"".PadLeft(100, '-')}
";
            File.AppendAllText(fileName, msg);
        }
    }
}
