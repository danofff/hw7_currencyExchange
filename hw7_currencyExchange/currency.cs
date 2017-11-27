using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_currencyExchange
{
    class currency
    {
        private string name;
        public string  Name
        {
            get { return name; }
            set { name = value; }
        }
        private double toDollar;
        public double ToDollar
        {
            get { return toDollar; }
            set { toDollar = value; }
        }
        public currency(double toDollar):this(toDollar,"noname")
        {
            this.ToDollar = toDollar;
        }
        public currency(double toDollar,string name)
        {
            this.ToDollar = toDollar;
            this.Name = name;
        }
        public void printCurInfo()
        {
            Console.WriteLine("Name: {0:f3}, To 1 dollar {1:f3}",this.Name,this.ToDollar);
        }
        public static bool operator ==(currency c1, currency c2)
        {
            return c1.toDollar == c2.ToDollar;
        }
        public static bool operator !=(currency c1, currency c2)
        {
            return c1.toDollar != c2.ToDollar;
        }
    }
}