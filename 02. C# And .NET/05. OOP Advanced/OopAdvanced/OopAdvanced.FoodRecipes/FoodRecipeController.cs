using System.Net.Http.Headers;

public class FoodRecipeController
{
    private readonly IFoodRecipeRepository _foodRecipeRepository;
    private readonly IUserInteraction _userInteraction;
    private readonly string fileName = "Recipe";
    public FoodRecipeController(IFoodRecipeRepository foodRecipeRepository, IUserInteraction userInteraction)
    {
        _foodRecipeRepository = foodRecipeRepository;
        _userInteraction = userInteraction;
    }

    internal void Execute()
    {
        var recipes = _foodRecipeRepository.GetAll(fileName);
        _userInteraction.PrintRecipes(recipes);
        _userInteraction.PromptForNewRecipe();
        var recipe = _userInteraction.GetRecipe();
        if (recipe == null)
        {
            _userInteraction.PrintMessage("Recipe is null.");
        }
        else
        {
            _userInteraction.PrintMessage("Recipe recieved.");
            if(recipe != null)
            {
                recipes = [];
            }
            recipes.Add(recipe);
            _foodRecipeRepository.Save(fileName,recipes);
        }
        _userInteraction.Exit();
    }
}