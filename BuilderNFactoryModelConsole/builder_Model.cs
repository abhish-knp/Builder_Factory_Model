using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndBuilderModel
{
    public class MealDirector
    {
        public void MakeMeal(MealBuilder mealBuilder)
        {
            mealBuilder.AddSandwich();
            mealBuilder.AddSideOrder();
            mealBuilder.AddDrink();
            mealBuilder.AddOfferItem();
            mealBuilder.SetPrice();
        }
    }


    public abstract class MealBuilder
    {
        public abstract void AddSandwich();
        public abstract void AddSideOrder();
        public abstract void AddDrink();
        public abstract void AddOfferItem();
        public abstract void SetPrice();
        public abstract Meal GetMeal();
    }


    public class JollyVegetarianMealBuilder : MealBuilder
    {
        private Meal _meal = new Meal();

        public override void AddSandwich() { _meal.Sandwich = "Vegeburger"; }
        public override void AddSideOrder() { _meal.SideOrder = "Fries"; }
        public override void AddDrink() { _meal.Drink = "Orange juice"; }
        public override void AddOfferItem() { _meal.Offer = "Donut voucher"; }
        public override void SetPrice() { _meal.Price = 4.99; }
        public override Meal GetMeal() { return _meal; }
    }


    public class MischievousMexicanBuilder : MealBuilder
    {
        private Meal _meal = new Meal();

        public override void AddSandwich() { _meal.Sandwich = "Spicy burger"; }
        public override void AddSideOrder() { _meal.SideOrder = "Nachos"; }
        public override void AddDrink() { _meal.Drink = "Tequila"; }
        public override void AddOfferItem() { _meal.Offer = "Hat"; }
        public override void SetPrice() { _meal.Price = 5.49; }
        public override Meal GetMeal() { return _meal; }
    }


    public class Meal
    {
        public string Sandwich { get; set; }
        public string SideOrder { get; set; }
        public string Drink { get; set; }
        public string Offer { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4:f2}",
                Sandwich, SideOrder, Drink, Offer, Price);
        }
    }
}
