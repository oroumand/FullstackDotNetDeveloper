
FoodRecipeController foodRecipeController = new(new FoodRecipeRepository(),new UserConsoleInteraction());
foodRecipeController.Execute();
