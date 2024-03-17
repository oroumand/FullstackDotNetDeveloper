using OopAdvanced.ExtensionSamples.Extensions;
//using OopAdvanced.TempExtensions.Extensions;
string CodeMelli = Console.ReadLine();

CodeMelli.IsCodeMelli();
CodeMelli.IsNumber();

Person person = new Person()
{
    Name = "Test",
    Id = 1
};

person.PrintFullName();