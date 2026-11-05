using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Ten san pham: " + Name);
            Console.WriteLine("Gia: " + Price + " VND");
        }
    }
    public class Phone : Product
    {
        public int StorageGB { get; set; }

        public void ShowStorage()
        {
            Console.WriteLine("Dung luong: " + StorageGB + " GB");
        }
    }
    public class Clothing : Product
    {
        public string Size { get; set; }

        public void ShowSize()
        {
            Console.WriteLine("Kich thuoc: " + Size);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Name = "iPhone 16";
            phone.Price = 20000000;
            phone.StorageGB = 128;

            Console.WriteLine("DIEN THOAI ");
            phone.ShowInfo();
            phone.ShowStorage();

            Console.WriteLine();

            Clothing shirt = new Clothing();
            shirt.Name = "Ao thun";
            shirt.Price = 250000;
            shirt.Size = "L";

            Console.WriteLine("QUAN AO ");
            shirt.ShowInfo();
            shirt.ShowSize();

            Console.ReadKey();
        }
    }
}
