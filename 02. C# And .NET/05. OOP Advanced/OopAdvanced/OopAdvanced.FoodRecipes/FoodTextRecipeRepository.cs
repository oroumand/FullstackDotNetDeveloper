
using OopAdvanced.FoodRecipes.Model;
using System.Text.Json;

public class FoodTextRecipeRepository : FoodRecipeRepository
{

    protected override string GetPath(string fileName) => $"{fileName}.txt";
}
