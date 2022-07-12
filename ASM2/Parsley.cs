using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2
{
    public class Parsley: Sauces
    {
        public Parsley(Salad sauceSalad) : base(sauceSalad)
        {
            this.myPrice = 1.00;
            this.description = ", Parsley ";
        }
    }
}
