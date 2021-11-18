using System;

namespace PizzaStore
{
    public class Drink : Food
    {
        private string _name;
        private double _price;

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