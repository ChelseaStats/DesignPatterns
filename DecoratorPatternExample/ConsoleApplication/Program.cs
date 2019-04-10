using System;
using System.Globalization;
using DecoratorPatternExample;
using DecoratorPatternExample.Decorators;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Decorator Pattern Knowledge Share";


            Console.WriteLine("The participants of a decorator pattern");
            Console.WriteLine("1 Interface Component : ICar");
            Console.WriteLine("2 Concrete component : Car");
            Console.WriteLine("3 Abstract decorator (this handles one piece of functionality that could be implemented differently in the concrete level,");
            Console.WriteLine("  The AD can also handle cases where you might want to limit the number of concrete decorators (if cost exceeds threshold)");
            Console.WriteLine("4 Concrete decorator : Sun Roof (for example)");
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();
            
            var car = new Car();
            Console.WriteLine("Car with no extras");
            Console.WriteLine("---");
            Console.WriteLine(car.GetDescription());
            Console.WriteLine(car.GetCost().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();


            var carWithExtra = new Car();
            var decoratedCar = new AlloyWheelsDecorator(carWithExtra);
            Console.WriteLine("Car with Alloys");
            Console.WriteLine("---");
            Console.WriteLine(decoratedCar.GetDescription());
            Console.WriteLine(decoratedCar.GetCost().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();

            var carWithSunRoof = new SunRoofDecorator(new Car());
            Console.WriteLine("Car with sun roof");
            Console.WriteLine("---");
            Console.WriteLine(carWithSunRoof.GetDescription());
            Console.WriteLine(carWithSunRoof.GetCost().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();

            var carWithHeatedSeats = new HeatedSeatsDecorator(new Car());
            Console.WriteLine("Car with heated seats");
            Console.WriteLine("---");
            Console.WriteLine(carWithHeatedSeats.GetDescription());
            Console.WriteLine(carWithHeatedSeats.GetCost().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();

            var carFullSpecs = new HeatedSeatsDecorator(new SunRoofDecorator(new AlloyWheelsDecorator(new ParkingSesnsorsDecorator(new Car()))));
            Console.WriteLine("Car with full specs");
            Console.WriteLine("---");
            Console.WriteLine(carFullSpecs.GetDescription());
            Console.WriteLine(carFullSpecs.GetCost().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();

            
            Console.WriteLine("---");
            Console.WriteLine("Pros");
            Console.WriteLine("---");
            Console.WriteLine("* Avoided class explosion ( car with alloys, car with heated seats, car with alloys and heated seats etc");
            Console.WriteLine("* Observing open/closed principle");
            Console.WriteLine("* extendable (LEDs, GPS, dump valves, gear box, electric...)");
            Console.WriteLine("\n\n");

            Console.WriteLine("Cons");
            Console.WriteLine("---");
            Console.WriteLine("* Constructor chain can get unwieldy: new HeatedSeatsDecorator(new SunRoofDecorator(new AlloyWheelsDecorator(new Car())))");
            Console.WriteLine("* Abstract class needs to have virtual methods, concrete decorators need to override (not new ones!)");
            Console.WriteLine("\n\n");


            Console.WriteLine("Summary");
            Console.WriteLine("---");

            Console.WriteLine("We saw a brief formal introduction of the Decorator Pattern and then we had a look at a concrete problem that this construct is a natural fit for. Another example could have been a Pizza or Coffee shop. Anything that deals with objects whose behaviors should be extendable dynamically would do.");
            Console.WriteLine("\n\n");
            Console.ReadKey();


        }

    }
}
