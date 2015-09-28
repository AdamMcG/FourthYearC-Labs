using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLab5
{
    class Program
    {
        static void Main()
        {
            Money m = new Money(Money.CurrencyTypes.Euro, 12333.32);
            Money m2 = new Money(Money.CurrencyTypes.Yen, 1222222222);
            Money m3 = new Money(Money.CurrencyTypes.Dollar, 3000.334);

        }
    }
}
