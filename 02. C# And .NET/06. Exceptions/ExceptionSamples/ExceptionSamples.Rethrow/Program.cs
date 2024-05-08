using ExceptionSamples.Rethrow;
try
{
    PersonController personController = new PersonController();

    personController.CreatePerson("Alrieza", "Oroumand");


}
catch (Exception ex)
{
    //Log
    Console.WriteLine("There is exception in applicaiton");
    Console.WriteLine("Press any key to close");
    Console.ReadKey();
}

