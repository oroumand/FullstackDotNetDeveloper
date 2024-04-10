
using OopAdvanced.FoodRecipes.Model;

public class UserConsoleInteraction : IUserInteraction
{
    private readonly IIngeridientRepository _ingeridientRepository;
    private readonly IFoodRecipeRepository _foodRecipeRepository;

    public UserConsoleInteraction(IIngeridientRepository ingeridientRepository,
        IFoodRecipeRepository foodRecipeRepository)
    {
        _ingeridientRepository = ingeridientRepository;
        _foodRecipeRepository = foodRecipeRepository;
    }
    public void Exit()
    {
        PrintMessage("Finish. Press any key...");
        Console.ReadKey();
    }

    public Recipe GetRecipe()
    {
        int id = 0;
        Recipe recipe = null;
        List<Ingredient> ingredients = [];
        do
        {
            string tempValue = Console.ReadLine();
            id = int.Parse(tempValue);
            if (id != 0)
            {
                var item = _ingeridientRepository.Find(id);
                if (item == null)
                {
                    PrintMessage("Select Correct Id or 0 for exit");
                }
                else
                {
                    PrintMessage($"Item added to list. select another item or 0 for exit");
                    ingredients.Add(item);
                }
            }
        } while (id != 0);
        if (ingredients.Count > 0)
        {
            Console.Write("Select Name for food: ");
            string name = Console.ReadLine();
            recipe = new Recipe(_foodRecipeRepository.GetNextId(), name, ingredients);
        }
        return recipe;


    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintRecipes(IEnumerable<Recipe> recipes)
    {
        if (recipes != null && recipes.Count() > 0)
        {
            PrintMessage($"Tehre is {recipes.Count()} recipes in recipe database");
            Console.WriteLine();
            foreach (var recipe in recipes)
            {
                PrintMessage(recipe.ToString());
                Console.WriteLine("".PadLeft(50, '-'));
                Console.WriteLine();
            }
        }
    }

    public void PromptForNewRecipe()
    {
        PrintMessage("Plese Select From List by Id or 0 for cancel");
        var allIngeridient = _ingeridientRepository.GetAll();
        PrintMessage(string.Join(Environment.NewLine, allIngeridient));

    }
}

public interface IUserInteraction
{
    void Exit();
    Recipe GetRecipe();
    void PrintMessage(string message);
    void PrintRecipes(IEnumerable<Recipe> recipes);
    void PromptForNewRecipe();
}
