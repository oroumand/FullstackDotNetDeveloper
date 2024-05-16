using GenericSamples.SimpleListImplementation;

ListInt listInt = new ListInt();
ListGeneric<string> names = new ListGeneric<string>();
names.Add("alireza");
names.Add("hassan");
names.Add("amirhossein");
names.Add("mohammad");

ListGeneric<Person> persons = new ListGeneric<Person>();
persons.Add(new Person
{
    FirstName = "Test",
    LastName = "Test",
});
Console.ReadLine();





