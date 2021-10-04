namespace PizzaStore
{
    public class Size
    {
        private string _name;
        private double _price;

        public Size(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public double Price
        {
            get => _price;
        }
    }
}
