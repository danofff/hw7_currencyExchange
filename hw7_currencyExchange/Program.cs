using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_currencyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            currency c1 = new currency(0.751, "pound sterling");
            currency c2 = new currency(0.845, "euro");

            CurConverter converter = new CurConverter();
            Console.WriteLine("{0:f3}",converter.Convert(c1, c2));

            currency c3 = new currency(58.42, "rubl");
            currency c4 = new currency(329.23, "tenge");

            Console.WriteLine("{0:f3}", converter.Convert(c3, c4,100));
        }
    }
}
