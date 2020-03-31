using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagram_klas_liczby
{
    public class Lepsze_liczby : Liczby
    {
        protected int d;

        public Lepsze_liczby(int a, int b, int c,int d) : base ( a,  b,  c)
        {
            this.d = d;
        }
        public Lepsze_liczby()
        {

        }
        public void pobierzD(int d)
        {
            this.d = d;
        }
        public int zwrocD()
        {
            return this.d;
        }
    };
}