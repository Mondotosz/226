using System.Collections.Generic;
using System.Linq;

namespace PizzaStore
{

    public class Order
    {
        private List<Pizza> _pizzas;
        private string _client;

        public Order(string client)
        {
            _pizzas = new List<Pizza>();
            _client = client;
        }

        public void AddPizza(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public override string ToString()
        {
            return generateReceipt();
        }

        private string generateReceipt(){
            return $"{_client}\n\n{string.Join("\n", _pizzas.Select(pizza => pizza.ToString()))}";
        }

        public double Price
        {
            get { return _pizzas.Sum(pizza => pizza.Price); }
        }

        public string Receipt
        {
            get => generateReceipt();
        }
    }
}