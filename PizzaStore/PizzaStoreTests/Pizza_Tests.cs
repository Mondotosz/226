using System;
using NUnit.Framework;
using PizzaStore;

namespace PizzaStoreTests
{
    public class Pizza_Tests
    {
        [Test]
        public void Empty_Pizza_To_String()
        {
            Pizza pizza = new Pizza(new Size("None", 0.0));
            Assert.AreEqual("None:", pizza.ToString());
        }

        [Test]
        public void Pizza_With_Ingredient(){
            Pizza pizza = new Pizza(new Size("Regular",14));
            pizza.AddIngredient(new Ingredient("Pineapple",2));
            Assert.AreEqual("Regular:Pineapple",pizza.ToString());
        }

        [Test]
        public void Pizza_With_Ingredients(){
            Pizza pizza = new Pizza(new Size("Regular",14));
            pizza.AddIngredient(new Ingredient("Pineapple",2));
            pizza.AddIngredient(new Ingredient("Apple",1.5));
            Assert.AreEqual("Regular:Pineapple,Apple",pizza.ToString());
        }
    }
}