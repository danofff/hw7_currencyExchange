using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_currencyExchange
{
    class cur_converter
    {
        public double convert(currency cur1,currency cur2,int quantity=1)
        {
            cur1.printCurInfo();
            cur2.printCurInfo();
            Console.Write($"{quantity} {cur1.Name} in {cur2.Name}: ");
            return quantity *(cur2.ToDollar / cur1.ToDollar);
        }
    }
}
