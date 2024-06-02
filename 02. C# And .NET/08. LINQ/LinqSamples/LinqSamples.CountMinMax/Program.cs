using LinqSamples.CountMinMax;

List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var numMoreThan6 = numbers.Where(c => c > 6).Count();
Console.WriteLine($"Count:{numMoreThan6}");

var min = numbers.Min();
var max = numbers.Max();
Console.WriteLine($"Min: {min} and Max: {max}");
List<Person> people = new List<Person>();
people.Add(new Person()
{
    Id = 1,
    Name = "Alireza",
    Age = 1,
});
people.Add(new Person()
{
    Id = 2,
    Name = "Hassan",
    Age = 100,
});
people.Add(new Person()
{
    Id = 3,
    Name = "Mohammad",
    Age = 55,
});
var maxage = people.Max(c => c.Age);

var person = people.Where(c => c.Age == maxage).First();

var oldMan = people.MaxBy(c => c.Age);
Console.WriteLine(person.Name);
Console.WriteLine(oldMan.Name);


Console.ReadLine();