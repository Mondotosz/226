using System;

namespace PizzaStore
{
    public class Drink : Food
    {
        private string _name;
        private double _price;

        public Drink(string name, double price){
            _name = name;
            _price = price;
        }
        public string Name
        {
            get => _name;
        }
        public override double Price
        {
            get => _price;
        }
    }
}