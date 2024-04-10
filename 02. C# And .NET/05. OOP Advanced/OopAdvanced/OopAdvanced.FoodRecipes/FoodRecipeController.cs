using System.Net.Http.Headers;

public class FoodRecipeController
{
    private readonly IFoodRecipeRepository _foodRecipeRepository;
    private readonly IUserInteraction _userInteraction;
    private readonly string filePath = "Recipe.txt";
    public FoodRecipeController(IFoodRecipeRepository foodRecipeRepository, IUserInteraction userInteraction)
    {
        _foodRecipeRepository = foodRecipeRepository;
        _userInteraction = userInteraction;
    }

    internal void Execute()
    {
        var recipes = _foodRecipeRepository.GetAll(filePath);
        _userInteraction.PrintRecipes(recipes);
        var recipe = _userInteraction.GetRecipe();
        if (recipe != null)
        {
            _userInteraction.PrintMessage("Recipe is null.");
        }
        else
        {
            _userInteraction.PrintMessage("Recipe recieved.");
            recipes.Add(recipe);
            _foodRecipeRepository.Save(recipes);
        }
        _userInteraction.PrintMessage("Finish");
    }
}