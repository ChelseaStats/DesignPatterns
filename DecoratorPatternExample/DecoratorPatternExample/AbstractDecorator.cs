namespace DecoratorPatternExample
{
    public abstract class AbstractDecorator : ICar
    {
        protected ICar Car;

        protected AbstractDecorator(ICar car)
        {
            Car = car;
        }

        public virtual string GetDescription()
        {
            return Car.GetDescription();
        }

        public virtual double GetCost()
        {
            return Car.GetCost();
        }

    }
}
