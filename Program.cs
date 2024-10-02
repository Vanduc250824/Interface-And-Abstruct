using Interface;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Khởi tạo các đối tượng sản phẩm
        MobilePhone phone = new MobilePhone("iPhone 13", 999m, 50);
        Laptop laptop = new Laptop("Dell XPS 13", 1500m, 20);
        Accessory accessory = new Accessory("Phone Case", 29.99m, 100);

        // Hiển thị thông tin sản phẩm
        Console.WriteLine("Thông tin sản phẩm trước khi giảm giá:");
        phone.DisplayProductinfo();
        laptop.DisplayProductinfo();
        accessory.DisplayProductinfo();

        // Thực hiện áp dụng giảm giá
        Console.WriteLine("\nÁp dụng giảm giá:");
        phone.ApplyDiscount(10); // Giảm giá 10%
        laptop.ApplyDiscount(15); // Giảm giá 15%
        accessory.ApplyDiscount(5); // Giảm giá 5%

        // Hiển thị thông tin sản phẩm sau khi giảm giá
        Console.WriteLine("\nThông tin sản phẩm sau khi giảm giá:");
        phone.DisplayProductinfo();
        laptop.DisplayProductinfo();
        accessory.DisplayProductinfo();

        // Thực hiện bán hàng
        Console.WriteLine("\nThực hiện bán hàng:");
        phone.Sell(5); // Bán 5 điện thoại
        laptop.Sell(2); // Bán 2 máy tính xách tay
        accessory.Sell(10); // Bán 10 phụ kiện

        // Kiểm tra tồn kho
        Console.WriteLine("\nKiểm tra tồn kho:");
        Console.WriteLine($"Điện thoại còn trong kho: {phone.IsInStock()}");
        Console.WriteLine($"Máy tính xách tay còn trong kho: {laptop.IsInStock()}");
        Console.WriteLine($"Phụ kiện còn trong kho: {accessory.IsInStock()}");
    }
}
