using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2
{
    public class Honey:Sauces
    {
        public Honey(Salad sauceSalad): base(sauceSalad)
        {
            this.myPrice = 1.99; 
            this.description = ", Honey ";
        }
    }
}
