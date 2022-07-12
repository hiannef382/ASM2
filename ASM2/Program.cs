using System;

namespace ASM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================== Welcome to Salad  Restaurant  ============================\n");
            Salad salad = new Salad(); 
            
            Console.WriteLine("\n+" + Salad.GetDescription() + Salad.GetPrice());

            Honey moreHoney = new Honey(salad);
            Honey someMoreHoney = new Honey(moreHoney);

            Console.WriteLine("\n+" + someMoreHoney.GetDescription() + someMoreHoney.GetPrice());

            Tahini moreTahini = new Tahini(someMoreHoney);
            Console.WriteLine("\n+" + moreTahini.GetDescription() + moreTahini.GetPrice());

            Parsley moreParsley = new Parsley(moreTahini);
            Console.WriteLine("\n+" + moreParsley.GetDescription() + moreParsley.GetPrice());

            Console.ReadLine();
        }
    }

}
    

