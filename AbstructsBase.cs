namespace Interface
{
    public abstract class Product
    {
        private string name;
        private decimal price;
        private int stock;

        public Product(string _name, decimal _Price, int _stock)
        {
            this.name = _name;
            this.price = _Price;
            this.stock = _stock;
        }
        public abstract void DisplayProductinfo();
        public abstract void ApplyDiscount(decimal percentage);
        public string Name => name;
        public decimal Price => price;
        public int Stock => stock;
    }
    public interface ISellable
    {
        void Sell(int Quantity);
        bool IsInStock();
    }
}


