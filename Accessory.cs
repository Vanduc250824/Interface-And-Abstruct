using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Accessory : Product, ISellable
    {
        public Accessory(string name, decimal price, int stock) : base(name, price, stock) { }
        public override void DisplayProductinfo()
        {

            Console.WriteLine($"Phu kien: {Name}, Gia: {Price}, Stock : {Stock}");
        }
        public override void ApplyDiscount(decimal percentage)
        {
            decimal discountPrice = Price - (Price * (percentage / 100));
            Console.WriteLine($"Gia tien moi sau khi giam {percentage}% : {discountPrice}");
        }
        public void Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Console.WriteLine($"Sold Out: {quantity}; Stock:{Stock - quantity}");
            }
            else
            {
                Console.WriteLine("Not enough to sold!!!!");
            }
        }
        public bool IsInStock() => Stock > 0;
    }
}
