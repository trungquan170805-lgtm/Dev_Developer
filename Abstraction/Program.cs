using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Discount
    {
        public abstract double Calculate(double price);
    }

    public class NormalDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * 0.9;
        }
    }

    public class VIPDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * 0.8;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 1000000;

            Discount normal = new NormalDiscount();
            Discount vip = new VIPDiscount();

            Console.WriteLine("Gia goc: " + price + " VND");
            Console.WriteLine("Khach thuong: " +
                normal.Calculate(price) + " VND");
            Console.WriteLine("Khach VIP: " +
                vip.Calculate(price) + " VND");

            Console.ReadKey();
        }
    }
}
