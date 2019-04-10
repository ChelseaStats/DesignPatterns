namespace DecoratorPatternExample.Decorators
{
    public class SunRoofDecorator : AbstractDecorator
    {

        private readonly ICar _car;
        private const double AddedExtraCost = 39.99;
        private const string AddedExtraDescription = "Sun Roof";

        public SunRoofDecorator(ICar car) : base(car)
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
