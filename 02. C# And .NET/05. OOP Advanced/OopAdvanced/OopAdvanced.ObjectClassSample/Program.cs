using OopAdvanced.ObjectClassSample.TestClasses;

Student student
    = new Student()
    {
        FirstName = "Alireza",
        LastName = "Oroumand",
        StudentNumber = "123"
    };
Person person = new Person()
{
    FirstName = "Mohammad",
    LastName = "Abbasi"
};
Console.WriteLine(student);

Console.WriteLine(person);

int myint = 123;
Console.WriteLine(myint);

DateTime today = DateTime.Now;
Console.WriteLine(today);
Console.ReadLine();
Temp temp = new Temp();
