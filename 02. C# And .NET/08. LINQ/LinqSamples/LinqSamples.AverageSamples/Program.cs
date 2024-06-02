using LinqSamples.AverageSamples;
using System.Reflection.Metadata.Ecma335;

var people = Person.GetList();
var avg = people.Average(c=>c.Age);

Console.WriteLine($"{avg}");

var selectedPerson = people.Select(c => new
{
    FullName = c.Name,
    MyAge = c.Age
});

foreach (var person in selectedPerson)
{
    Console.WriteLine($"{person.FullName} {person.MyAge}");
}
Console.ReadLine();