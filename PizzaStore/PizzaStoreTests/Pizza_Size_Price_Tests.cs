using NUnit.Framework;
using PizzaStore;

namespace PizzaStoreTests
{
    public class Pizza_Size_Price_Tests
    {
        [Test]
        public void Pizza_With_Size_Regular_Has_Correct_Price()
        {
            Pizza pizza = new Pizza(new Size("Regular", 10.0));
            Assert.AreEqual(10.0, pizza.Price);
        }

        [Test]
        public void Pizza_With_Size_Family_Has_Correct_Price()
        {
            Pizza pizza = new Pizza(new Size("Family", 20.0));
            Assert.AreEqual(20.0, pizza.Price);
        }

        [Test]
        public void Pizza_With_Size_Mini_Has_Correct_Price()
        {
            Pizza pizza = new Pizza(new Size("Mini", 8.0));
            Assert.AreEqual(8.0, pizza.Price);
        }
    }
}
