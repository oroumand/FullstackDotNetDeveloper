// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public abstract class Animal
{
    protected int age;
    public string Name { get; set; }
    public abstract string SaySomthings();
}

public class Cat : Animal
{
    public override string SaySomthings()
    {
        throw new NotImplementedException();
    }
}
public class Dog : Animal
{
    public override string SaySomthings()
    {
        throw new NotImplementedException();
    }
}

public abstract class Bird:Animal, IFlyable
{
    public abstract void Fly();
}


public interface IFlyable
{
    void Fly();
}
public class Parrot : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException();
    }

    public override string SaySomthings()
    {
        throw new NotImplementedException();
    }
}

public class VasayelHamlonaghl
{

}

public class Plane : VasayelHamlonaghl, IFlyable
{
    public void Fly()
    {
        throw new NotImplementedException();
    }
}