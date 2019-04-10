using System;

namespace FacadePatternExample.Kitchen
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class ColdPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            Console.WriteLine("Cold Prep is preparing Appetizer #" + dishId);
            //Go prep the appetizer
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}