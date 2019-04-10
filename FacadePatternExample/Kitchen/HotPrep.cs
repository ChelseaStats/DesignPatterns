using System;

namespace FacadePatternExample.Kitchen
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class HotPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            Console.WriteLine("Hot Prep is preparing Entree #" + dishId);
            //Go prep the entree
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}