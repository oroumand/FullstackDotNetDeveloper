using LinqSamples.SortOrder;

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

var orderdByName = people.OrderBy(comparer => comparer.Name).ThenBy(c => c.Age).ToList();
var orderdByNameDesc = people.OrderByDescending(comparer => comparer.Name).ThenByDescending(c => c.Age).ToList();
