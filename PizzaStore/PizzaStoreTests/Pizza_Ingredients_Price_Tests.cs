using NUnit.Framework;
using PizzaStore;

namespace PizzaStoreTests
{
    public class Pizza_Ingredients_Price_Tests
    {
        private Pizza _pizza;

        [SetUp]
        public void Setup()
        {
            _pizza = new Pizza(new Size("None", 0.0));
        }

        [Test]
        public void Empty_Pizza_Has_Correct_Price()
        {
            Assert.AreEqual(0.0, _pizza.Price);
        }

        [Test]
        public void Pizza_With_One_Ingredient_Has_Correct_Price()
        {
            Ingredient ingredient = new Ingredient("Ham", 2.5);
            _pizza.AddIngredient(ingredient);

            Assert.AreEqual(2.5, _pizza.Price);
        }

        [Test]
        public void Pizza_With_Two_Ingredients_Has_Correct_Price()
        {
            Ingredient ingredient = new Ingredient("Ham", 2.5);
            Ingredient other = new Ingredient("Mushroom", 1.0);

            _pizza.AddIngredient(ingredient);
            _pizza.AddIngredient(other);

            Assert.AreEqual(3.5, _pizza.Price);
        }

        [Test]
        public void Pizza_With_Two_Similar_Ingredients_Has_Correct_Price()
        {
            Ingredient ingredient = new Ingredient("Ham", 2.5);
            _pizza.AddIngredient(ingredient);
            _pizza.AddIngredient(ingredient);

            Assert.AreEqual(5.0, _pizza.Price);
        }
    }
}