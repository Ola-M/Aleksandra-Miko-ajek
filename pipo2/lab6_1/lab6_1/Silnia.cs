using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
   public class Silnia
    {
        private int liczba;
        public int Result()
        {
            int y=1;
            for(int i = liczba; i>0 ; i--)
            {
               y*= i;
            }
            return y;
        }
        
        public int  GetLiczba()
        {
            return liczba;
        }
        public void SetLiczba(int n)
        {
            liczba = n;
        }


    }
}
