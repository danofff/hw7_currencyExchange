using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_currencyExchange
{
    class CurConverter
    {
        public double Convert(currency cur1,currency cur2, int quantity=1)
        {
            cur1.PrintCurInfo();
            cur2.PrintCurInfo();

            Console.Write($"{quantity} {cur1.Name} in {cur2.Name}: ");
            return quantity *(cur2.ToDollar / cur1.ToDollar);
        }
    }
}
