var foodRepository = new FoodTextRecipeRepository();
var ingRepository = new IngeridientRepository();
var UserConsoleInteraction = new UserConsoleInteraction(ingRepository, foodRepository);

FoodRecipeController foodRecipeController = new(foodRepository, UserConsoleInteraction);
foodRecipeController.Execute();
