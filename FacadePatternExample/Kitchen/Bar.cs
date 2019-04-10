using System;

namespace FacadePatternExample.Kitchen
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class Bar : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            Console.WriteLine("The Bar is preparing Drink #" + dishId);
            //Go mix the drink
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}