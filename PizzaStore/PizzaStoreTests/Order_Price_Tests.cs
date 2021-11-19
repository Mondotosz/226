using NUnit.Framework;
using PizzaStore;

namespace PizzaStoreTests
{
    public class Pizza_Size_Price_Tests
    {
        private Order _order;

        [SetUp]
        public void Setup()
        {
            _order = new Order("Joe");
        }

        [Test]
        public void Empty_Order_Has_Correct_Price()
        {
            Assert.AreEqual(0.0, _order.Price);
        }

        [Test]
        public void Order_With_One_Pizza_Has_Correct_Price()
        {
            Pizza pizza = new Pizza(new Size("Regular", 10.0));
            _order.AddFood(pizza);

            Assert.AreEqual(10.0, _order.Price);
        }

        [Test]
        public void Order_With_Two_Pizzas_Has_Correct_Price()
        {
            Pizza pizza1 = new Pizza(new Size("Regular", 10.0));
            _order.AddFood(pizza1);

            Pizza pizza2 = new Pizza(new Size("Regular", 15.0));
            _order.AddFood(pizza2);

            Assert.AreEqual(25.0, _order.Price);
        }

        [Test]
        public void Order_With_One_Drink_Has_Correct_Price()
        {
            Drink drink = new Drink("De l'ô", 9.5);
            _order.AddFood(drink);

            Assert.AreEqual(9.5, _order.Price);
        }

        [Test]
        public void Order_With_Two_Drinks_Has_Correct_Price()
        {
            Drink drink1 = new Drink("De l'ô", 9.5);
            _order.AddFood(drink1);

            Drink drink2 = new Drink("Bear", 3.5);
            _order.AddFood(drink2);

            Assert.AreEqual(13.0, _order.Price);
        }

        [Test]
        public void Order_With_Pizzas_And_Drinks_Has_Correct_Price()
        {
            Pizza pizza = new Pizza(new Size("Regular", 15.0));
            _order.AddFood(pizza);

            Drink drink = new Drink("De l'ô", 9.5);
            _order.AddFood(drink);

            Assert.AreEqual(24.5, _order.Price);
        }
    }
}
