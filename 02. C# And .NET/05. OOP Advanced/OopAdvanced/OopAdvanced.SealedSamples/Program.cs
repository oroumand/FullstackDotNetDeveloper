public abstract class Animal
{
    public string Name { get; set; }

    public abstract string SaySomthing();
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
    public override sealed string SaySomthing()
    {
        return "Hap";
    }
}

public sealed class GermanShepherd:Dog
{

}

