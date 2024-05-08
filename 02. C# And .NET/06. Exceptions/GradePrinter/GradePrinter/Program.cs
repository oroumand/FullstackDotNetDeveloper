using GradePrinter.App;
using GradePrinter.Loggers;
Logger logger = new("Log.txt");
var userInteractor = new ConsoleUserInteractor();
var gradePrinter = new StudentsGradePrinter(userInteractor);
var studentDataDeserializer = new StudentJsonDataDeserializer(userInteractor);
try
{
    GradePrinterService gradePrinterService = new(userInteractor, gradePrinter, studentDataDeserializer);
    gradePrinterService.Execute();

}
catch (Exception ex)
{
    logger.LogError(ex);
    userInteractor.PrintError("the application has encountered a problem and finished unexpectedly");

}
userInteractor.PrintMessage("Press any key");
Console.ReadKey();