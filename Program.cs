using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndBuilderModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factory Model
            { 
            PurchaseFactory spf = new StandardPurchaseFactory();
            Client standard = new Client(spf);
            Console.WriteLine(standard.ClientPackaging.GetType());
            Console.WriteLine(standard.ClientDocument.GetType());

            PurchaseFactory dpf = new DelicatePurchaseFactory();
            Client delicate = new Client(dpf);
            Console.WriteLine(delicate.ClientPackaging.GetType());
            Console.WriteLine(delicate.ClientDocument.GetType());
            }

            // Builder Model            
            {
                MealDirector director = new MealDirector();
                MealBuilder jvmb = new JollyVegetarianMealBuilder();
                director.MakeMeal(jvmb);
                Meal vegMeal = jvmb.GetMeal();
                Console.WriteLine(vegMeal);
                Console.WriteLine();

                MealBuilder mmmb = new MischievousMexicanBuilder();
                director.MakeMeal(mmmb);
                Meal mexMeal = mmmb.GetMeal();
                Console.WriteLine(mexMeal);
            }
            
        }

        
    }
}
