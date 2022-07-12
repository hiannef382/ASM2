using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2
{
    public abstract class Salad
    {
        protected double myPrice;
        protected string description = "Unknow Salad"; 
        public virtual double GetPrice()
        {
            return this.myPrice;
        }
        public virtual string GetDescription()
        {
            return this.description;
        }
    }

} 
