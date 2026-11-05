using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_SOLID
{
    public interface IPackaging
    {
        int CalculateFee();
    }

    public class NormalPackaging : IPackaging
    {
        public int CalculateFee()
        {
            return 10000;
        }
    }

    public class GiftPackaging : IPackaging
    {
        public int CalculateFee()
        {
            return 30000;
        }
    }

    public class PackagingService
    {
        public void ShowFee(IPackaging packaging)
        {
            Console.WriteLine("Phi dong goi: "
                + packaging.CalculateFee() + " VND");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PackagingService service = new PackagingService();

            Console.WriteLine("DONG GOI THUONG ");
            service.ShowFee(new NormalPackaging());

            Console.WriteLine();

            Console.WriteLine("DONG GOI HOP QUA ");
            service.ShowFee(new GiftPackaging());

            Console.ReadKey();
        }
    }
}
