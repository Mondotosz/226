using System.Collections.Generic;
using System.Linq;

namespace PizzaStore
{

    public class Order
    {
        private List<Pizza> _pizzas;

        public Order()
        {
            _pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public override string ToString()
        {
            return string.Join("\n", _pizzas.Select(pizza => pizza.ToString()));
        }

        public double Price
        {
            get { return _pizzas.Sum(pizza => pizza.Price); }
        }
    }
}