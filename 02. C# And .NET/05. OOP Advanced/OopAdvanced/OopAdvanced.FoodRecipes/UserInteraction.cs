
public class UserConsoleInteraction: IUserInteraction
{
    public object GetRecipe()
    {
        throw new NotImplementedException();
    }

    public void PrintMessage(string v)
    {
        throw new NotImplementedException();
    }

    public void PrintRecipes(object recipes)
    {
        throw new NotImplementedException();
    }
}

public interface IUserInteraction
{
    object GetRecipe();
    void PrintMessage(string v);
    void PrintRecipes(object recipes);

}