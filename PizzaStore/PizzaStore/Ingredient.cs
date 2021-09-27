namespace PizzaStore
{
    public class Ingredient
    {
        private string _name;
        private double _price;

        public Ingredient(string name, double price) {
            _name = name;
            _price = price;
        }

        public double Price {
            get => _price;
        }
    }
}
