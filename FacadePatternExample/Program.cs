using System;

namespace FacadePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Facade Design Pattern Knowledge Share";
            Console.WriteLine();

            Console.WriteLine("The participants of a facade pattern");
            Console.WriteLine("1 subsystems - all the complexity : a restaurant in this example");
            Console.WriteLine("2 the facade - the layer of abstraction above the subsystems");
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();

            var server = new Server();

            Console.WriteLine("Hello!  I'll be your server today. What is your name?");
            var name = Console.ReadLine();

            var customer = new Customer(name);

            Console.WriteLine("Hello " + customer.Name + ". What appetizer would you like? (1-15):");
            var appId = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
            var entreeId = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
            var drinkId = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("\n\n");
            Console.WriteLine("I'll get that order in right away.");

            Console.WriteLine("\n\n");
            server.PlaceOrder(customer, appId, entreeId, drinkId);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Pros");
            Console.WriteLine("---");
            Console.WriteLine("* Simple to implement, one of the easiest to learn");
            Console.WriteLine("* Reduces the complexity of interfacing with an entire (sub)system");
            Console.WriteLine("* A facade allows you to have exactly the required coupling between two entities");

            Console.WriteLine("\n\n");

            Console.WriteLine("Cons");
            Console.WriteLine("---");
            Console.WriteLine("* Doesn't solve the underlying complex code (but maybe that's a good thing too)");
            Console.WriteLine("* Similar to Adapter and Proxy patterns - could lead to decision paralysis");
            Console.WriteLine("\n\n");


            Console.WriteLine("Summary");
            Console.WriteLine("---");
            Console.WriteLine("We saw a brief formal introduction of the Facade Pattern and then we had a look at a concrete problem that this construct is a natural fit for. There are thousands of examples where complex code can be 'hidden away' behind a facade.");
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}