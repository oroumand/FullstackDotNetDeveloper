
public class FoodRecipeRepository: IFoodRecipeRepository
{
    public object GetAll(string filePath)
    {
        throw new NotImplementedException();
    }

    public void Save(object recipes)
    {
        throw new NotImplementedException();
    }
}

public interface IFoodRecipeRepository
{
    object GetAll(string filePath);
    void Save(object recipes);
}