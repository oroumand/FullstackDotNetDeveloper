using OopAdvanced.SerializationSample;

Person person = new Person
{
    Id = 1,
    Name = "Alireza",
    Family = "Oroumand",
    Description="This is Alireza Oroumand"
};
var textPerson = System.Text.Json.JsonSerializer.Serialize(person);
Person person1 = System.Text.Json.JsonSerializer.Deserialize<Person>("{\"Id\":1,\"Name\":\"Alireza\",\"Family\":\"Oroumand\",\"Description\":\"This is Alireza Oroumand\"}");
Console.WriteLine(textPerson);
Console.ReadLine();