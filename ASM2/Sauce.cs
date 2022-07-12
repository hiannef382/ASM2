using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2
{
    public abstract class Sauces : Salad
    {
        protected Salad salad;

        public Sauces(Salad sauceSalad)
        {
            this.salad = sauceSalad;
        }

        public override double GetPrice()
        {
            return (this.salad.GetPrice() + this.myPrice);
        }

        public override string GetDescription()
        {
            return (this.salad.GetDescription() + this.description);
        }
    }

}
