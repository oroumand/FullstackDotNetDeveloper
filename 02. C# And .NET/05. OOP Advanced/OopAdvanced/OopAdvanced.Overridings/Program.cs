Cat cat = new();
Dog dog = new Dog();
Console.WriteLine(cat.Name);
Console.WriteLine(dog.Name);

Animal animal = new();
Console.WriteLine(animal.Name);
Console.WriteLine("Cat From Base class");
Animal animal1 = new Cat();
Console.WriteLine(animal1.Name);

Console.ReadLine();

public class Animal
{
    public virtual string Name => "Animal";

}
public class Cat: Animal
{
    public override string Name => "Cat";
}

public class Dog: Animal
{
    public string Name => "Dog";

}