using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram_klas_liczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Liczby L1 = new Liczby(2, 3, 4);
            Liczby L2 = new Liczby();
            L2.pobierzA(1);
            L2.pobierzA(2);
            L2.pobierzC(7);
            Lepsze_liczby LL1 = new Lepsze_liczby();
            LL1.pobierzA(8);
            LL1.pobierzB(54);
            LL1.pobierzC(4);
            LL1.pobierzD(76);
        }
    }
}
