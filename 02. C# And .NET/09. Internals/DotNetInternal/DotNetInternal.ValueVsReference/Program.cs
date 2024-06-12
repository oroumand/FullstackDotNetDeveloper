using DotNetInternal.ValueVsReference;

int myAge = 40;
int yourAge = myAge;
Person me = new Person();
me.Age = 40;
Person you = me;
you.Age++;

addAge(myAge);
AddPersonAge(me);
yourAge++;
Console.WriteLine($"My age is= {myAge}");
Console.WriteLine($"Your age is= {yourAge}");

Console.WriteLine($"My age in class is= {me.Age}");
Console.WriteLine($"Your age in class is= {you.Age}");
Console.ReadLine();


void addAge(int age)
{
    age++;
}

void AddPersonAge(Person person)
{
    person.Age++;
}