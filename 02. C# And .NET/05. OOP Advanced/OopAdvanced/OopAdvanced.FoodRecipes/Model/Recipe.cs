namespace OopAdvanced.FoodRecipes.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Recipe()
        {

        }
        public Recipe(int id, string name, List<Ingredient> ingredients)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
        }
        public List<Ingredient> Ingredients { get; set; }



        public override string ToString() =>
            $"{Id}: {Name}, Ingredients:{Environment.NewLine} {string.Join(Environment.NewLine, Ingredients)}";
    }
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{Id}: {Name}";

    }
}
