using System;
using NUnit.Framework;
using PizzaStore;

namespace PizzaStoreTests
{
    public class Order_Tests
    {

        [Test]
        public void Correct_String_One_Pizza()
        {
            Order order = new Order("test client");
            Pizza pizza1 = new Pizza(new Size("regular", 12));
            pizza1.AddIngredient(new Ingredient("Capers", 2));
            pizza1.AddIngredient(new Ingredient("Olives", 2));
            order.AddPizza(pizza1);
            Assert.AreEqual("test client\n\nregular:Capers,Olives", order.ToString());
        }

        [Test]
        public void Correct_String_Multiple_Pizzas()
        {
            Order order = new Order("test client");
            Pizza pizza1 = new Pizza(new Size("regular", 12));
            Pizza pizza2 = new Pizza(new Size("Family", 19));
            pizza1.AddIngredient(new Ingredient("Capers", 2));
            pizza1.AddIngredient(new Ingredient("Olives", 2));
            pizza2.AddIngredient(new Ingredient("Merguez", 3));
            pizza2.AddIngredient(new Ingredient("Pineapple", 2));
            order.AddPizza(pizza1);
            order.AddPizza(pizza2);
            Assert.AreEqual("test client\n\nregular:Capers,Olives\nFamily:Merguez,Pineapple", order.ToString());
        }

        [Test]
        public void Correct_Price_One_Pizza()
        {
            Order order = new Order("test client");
            Pizza pizza1 = new Pizza(new Size("regular", 12));
            pizza1.AddIngredient(new Ingredient("Capers", 2));
            pizza1.AddIngredient(new Ingredient("Olives", 2));
            order.AddPizza(pizza1);
            Assert.AreEqual(16, order.Price);
        }

        [Test]
        public void Correct_Price_Multiple_Pizzas()
        {
            Order order = new Order("test client");
            Pizza pizza1 = new Pizza(new Size("regular", 12));
            Pizza pizza2 = new Pizza(new Size("Family", 19));
            pizza1.AddIngredient(new Ingredient("Capers", 2));
            pizza1.AddIngredient(new Ingredient("Olives", 2));
            pizza2.AddIngredient(new Ingredient("Merguez", 3));
            pizza2.AddIngredient(new Ingredient("Pineapple", 2));
            order.AddPizza(pizza1);
            order.AddPizza(pizza2);
            Assert.AreEqual(40, order.Price);
        }
    }
}