using LinqSamples;

var people = Person.GetList();


var moreThan50 = people.Where(c => c.Age > 50);
foreach (var item in moreThan50)
{
    Console.WriteLine($"{item.Name}-{item.Age}");
}
List<int> moreThan50Ages = people.Where(c => c.Age > 50).
    Select(c=>c.Age).ToList().Distinct().ToList();
foreach (var item in moreThan50Ages)
{
    Console.WriteLine($"{item}");
}

Console.ReadLine();

