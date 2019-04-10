namespace DecoratorPatternExample.Decorators
{
    public class AlloyWheelsDecorator : AbstractDecorator
    {

        private readonly ICar _car;
        private const double AddedExtraCost = 99.99;
        private const string AddedExtraDescription = "Alloy wheels";

        public AlloyWheelsDecorator(ICar car) : base(car)
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
