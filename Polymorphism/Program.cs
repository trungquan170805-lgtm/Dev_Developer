using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Payment
    {
        public virtual void Pay()
        {
            Console.WriteLine("Dang thanh toan...");
        }
    }

    public class CashPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Thanh toan 500000 VND bang tien mat");
        }
    }


    public class BankPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Thanh toan 500000 VND bang chuyen khoan");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Payment payment1 = new CashPayment();
            Payment payment2 = new BankPayment();

            payment1.Pay();
            payment2.Pay();

            Console.ReadKey();
        }
    }
}
