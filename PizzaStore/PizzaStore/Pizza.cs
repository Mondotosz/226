using System.Collections.Generic;
using System.Linq;

namespace PizzaStore
{
    public class Pizza
    {
        private Size _size;
        private List<Ingredient> _ingredients;

        public Pizza(Size size)
        {
            _size = size;
            _ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public double Price
        {
            get
            {
                return _ingredients.Sum(ingredient => ingredient.Price) + _size.Price;
            }
        }
    }
}
