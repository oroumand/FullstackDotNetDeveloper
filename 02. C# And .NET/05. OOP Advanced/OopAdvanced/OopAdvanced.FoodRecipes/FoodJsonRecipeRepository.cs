
using OopAdvanced.FoodRecipes.Model;
using System.Text.Json;
public abstract class FoodRecipeRepository : IFoodRecipeRepository
{
    protected List<Recipe> _all;
    public List<Recipe> GetAll(string fileName)
    {
        string filePath = GetPath(fileName);
        bool fileExists = FileExists(fileName);
        if (fileExists)
        {
            var jsonText = System.IO.File.ReadAllText(filePath);
            _all = JsonSerializer.Deserialize<List<Recipe>>(jsonText);
        }
        return _all;
    }

    protected virtual bool FileExists(string fileName)
    {
        string filePath = GetPath(fileName);
        return File.Exists(filePath);
    }

    public int GetNextId() => _all != null ?
        _all.Count() + 1 : 1;

    public void Save(string fileName, List<Recipe> recipes)
    {
        string recipesAsString = System.Text.Json.JsonSerializer.Serialize<List<Recipe>>(recipes);
        string filePath = GetPath(fileName);
        File.WriteAllText(filePath, recipesAsString);
    }

    protected abstract string GetPath(string fileName);
}
public class FoodJsonRecipeRepository : FoodRecipeRepository
{
    protected override string GetPath(string fileName) => $"{fileName}.json";
}
