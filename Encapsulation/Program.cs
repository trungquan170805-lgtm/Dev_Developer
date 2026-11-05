using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class EncapsulationDemo
    {
        private int stock = 10;

        public void Sell(int quantity)
        {
            if (quantity <= 0 || quantity > stock)
            {
                Console.WriteLine("So luong khong hop le!");
                return;
            }

            stock -= quantity;
            Console.WriteLine($"Da ban {quantity} san pham");
            Console.WriteLine($"Ton kho con: {stock}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EncapsulationDemo demo = new EncapsulationDemo();

            demo.Sell(5);
            demo.Sell(15);

            Console.ReadKey();
        }
    }
}
