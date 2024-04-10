
using OopAdvanced.FoodRecipes.Model;

public class IngeridientRepository : IIngeridientRepository
{
    private readonly IEnumerable<Ingredient> _ingredients = new List<Ingredient>
        {
            new() {
                Id = 1,
                Name ="Roghan"
            },
            new() {
                Id = 2,
                Name ="Tokhme Morgh"
            },
            new() {
                Id = 3,
                Name ="Namak"
            },
            new() {
                Id = 4,
                Name ="Goje"
            },
            new() {
                Id = 5,
                Name ="Morgh"
            },
            new() {
                Id = 6,
                Name ="Felfel"
            },
            new() {
                Id = 7,
                Name ="Nan"
            },
        };
    public Ingredient Find(int id)
    {
        foreach (var item in _ingredients)
        {
            if(item.Id == id)
                return item;    
        }
        return null;
    }

    public IEnumerable<Ingredient> GetAll() => _ingredients;
}