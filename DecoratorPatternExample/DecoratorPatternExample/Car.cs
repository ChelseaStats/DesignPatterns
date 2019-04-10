namespace DecoratorPatternExample
{
    public class Car : ICar
    {
        private readonly double _baseCost;
        private readonly string _baseDescription;

        public Car()
        {
            _baseCost = 5000.00;
            _baseDescription = "Entry Level car";
        }

        public string GetDescription()
        {
            return _baseDescription;
        }

        public double GetCost()
        {
            return _baseCost;
        }

    }
}
