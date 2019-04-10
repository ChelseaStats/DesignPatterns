using System;
using FacadePatternExample.Kitchen;

namespace FacadePatternExample
{
    /// <summary>
    /// The actual "Facade" class, which hides the complexity of the KitchenSection classes.
    /// After all, there's no reason a patron should order each part of their meal individually.
    /// </summary>
    class Server
    {
        private readonly ColdPrep _coldPrep = new ColdPrep();
        private readonly Bar _bar = new Bar();
        private readonly HotPrep _hotPrep = new HotPrep();

        public Order PlaceOrder(Customer customer, int coldAppId, int hotEntreeId, int drinkId)
        {
            Console.WriteLine($"{customer.Name} has placed an order for cold appetizer #{coldAppId}, hot entree #{hotEntreeId}, and drink #{drinkId}");

            var order = new Order
            {
                Appetizer = _coldPrep.PrepDish(coldAppId),
                Entree = _hotPrep.PrepDish(hotEntreeId),
                Drink = _bar.PrepDish(drinkId)
            };

            return order;
        }
    }
}