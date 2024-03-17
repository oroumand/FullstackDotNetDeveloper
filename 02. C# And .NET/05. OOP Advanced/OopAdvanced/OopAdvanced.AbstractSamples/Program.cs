// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Animal a = new Animal();
Cat cat = new Cat();
Animal dog = new Dog();

public abstract class Animal
{
    public string Name { get; set; }

    public abstract  string SaySomthing();
}

public abstract class Mammal : Animal
{
}

public class Cat : Mammal
{
    public override string SaySomthing()
    {
        return "Mio";
    }

}
public class Dog : Mammal
{
    public override string SaySomthing()
    {
        return "Hap";
    }
}