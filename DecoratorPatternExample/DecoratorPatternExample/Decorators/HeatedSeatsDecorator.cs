namespace DecoratorPatternExample.Decorators
{
    public class HeatedSeatsDecorator : AbstractDecorator
    {

        private readonly ICar _car;
        private const double AddedExtraCost = 149.99;
        private const string AddedExtraDescription = "Heated Seats";

        public HeatedSeatsDecorator(ICar car) : base(car)
        {
            _car = car;
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", with " + AddedExtraDescription;
        }

        public override double GetCost()
        {
            return _car.GetCost() + AddedExtraCost;
        }
    }
}
