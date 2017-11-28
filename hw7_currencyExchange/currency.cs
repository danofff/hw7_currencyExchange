using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_currencyExchange
{
    class currency
    {
        public string Name { get; set; }
        public double ToDollar { get; set; }

        public currency(double toDollar):this(toDollar,"noname"){}
        public currency(double toDollar,string name)
        {
            ToDollar = toDollar;
            Name = name;
        }

        public void PrintCurInfo()
        {
            Console.WriteLine("Name: {0:f3}, To 1 dollar {1:f3}",this.Name,this.ToDollar);
        }

        public static bool operator ==(currency c1, currency c2)
        {
            return c2 != null && (c1 != null && c1.ToDollar == c2.ToDollar);
        }

        public static bool operator !=(currency c1, currency c2)
        {
            return c2 != null && (c1 != null && c1.ToDollar != c2.ToDollar);
        }
    }
}