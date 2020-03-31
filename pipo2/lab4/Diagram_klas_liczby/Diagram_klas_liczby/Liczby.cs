using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagram_klas_liczby
{
    public class Liczby
    {
        protected int a;
        protected int b;
        protected int c;

        public Liczby(int a,int b, int c)
        {
           this.a = a;
           this.b = b;
           this.c = c;
        }
        public Liczby() { }
        public void pobierzA(int a)
        {

            this.a = a;
        }
        public void pobierzB(int b)
        {
            this.b = b; 
        }
        public void pobierzC(int c)
        {
            this.c = c;
        }  
        public int zwrocA()
        {
            return this.a;
        }
        public int zwrocB()
        {
            return this.b;
        }
        public int zwrocC()
        {
            return this.c;
        }

    }
}