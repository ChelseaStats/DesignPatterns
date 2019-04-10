namespace DecoratorPatternExample.Decorators
{
    public class ParkingSesnsorsDecorator : AbstractDecorator
    {

        private readonly ICar _car;
        private const double AddedExtraCost = 499.99;
        private const string AddedExtraDescription = "Parking sensors";

        public ParkingSesnsorsDecorator(ICar car) : base(car)
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
