
using OopAdvanced.FoodRecipes.Model;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using static FoodTextRecipeRepository;
public interface IFoodRecipeRepository
{
    List<Recipe> GetAll(string fileName);
    void Save(string fileName, List<Recipe> recipes);
    int GetNextId();
}