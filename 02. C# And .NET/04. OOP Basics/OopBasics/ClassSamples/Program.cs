using ClassSamples;
using System.Reflection.Metadata.Ecma335;

//Person person = new("Alireza","Oroumand");
//PersonPrinter printer = new();
//printer.Print(person);
//person.Rename("New Alireza");

//Calculator calculator = new Calculator();
//calculator.Add(1,2,3,4);
//calculator.Add(1,2,3);


//calculator.Add(1, 2);
//if(Person.AdultAge > 15)
//{
//    Person person = new Person("", "");

//}


//MyColor red = new MyColor(255,0,0);

//Student student = new Student();
//student.LastName = "Test";
//Console.WriteLine(student.LastName);

//Book book = new Book();
//book.Description = "The best book for learning ASP.NET";
//book.Name = "Pro ASP.NET Core";


//Book efbook = new Book("First book  name","First book Description")
//{
//    //Name = "Pro EF Core In Action",
//    Description = "The Best book for learning EF Core"
//};
Book efbook = new Book
{
    Name = "Pro EF Core In Action",
    //Description = "The Best book for learning EF Core"
};

Console.WriteLine($"{efbook.Name}: {efbook.Description}");

Console.ReadLine();


public class Book
{
    //public Book(string name, string decription)
    //{
    //    Name = name;
    //    Description = decription;
    //}

    public required string Name { get; set; }
    public string Description { get; init; }

}