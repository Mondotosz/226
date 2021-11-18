using System.Collections.Generic;
using System.Linq;

namespace PizzaStore
{

    public class Order
    {
        private List<Food> _foods;
        private string _client;

        public Order(string client)
        {
            _foods = new List<Food>();
            _client = client;
        }

        public void AddPizza(Food food)
        {
            _foods.Add(food);
        }

        public override string ToString()
        {
            return generateReceipt();
        }

        private string generateReceipt(){
            return $"{_client}\n\n{string.Join("\n", _foods.Select(food => food.ToString()))}";
        }

        public double Price
        {
            get { return _foods.Sum(food => food.Price); }
        }

        public string Receipt
        {
            get => generateReceipt();
        }
    }
}