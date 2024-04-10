
using OopAdvanced.FoodRecipes.Model;

public interface IIngeridientRepository
{
    Ingredient Find(int id);
    IEnumerable<Ingredient> GetAll();
}
