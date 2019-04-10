namespace FacadePatternExample.Kitchen
{
    /// <summary>
    /// Each section of the kitchen must implement this interface.
    /// </summary>
    interface IKitchenSection
    {
        FoodItem PrepDish(int dishId);
    }
}