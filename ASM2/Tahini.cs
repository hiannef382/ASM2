using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2
{
    public class Tahini: Sauces
    {
        public Tahini(Salad sauceSalad) : base(sauceSalad)
        {
            this.myPrice = 2.49;
            this.description = ", Tahini ";
        }
    }
}
