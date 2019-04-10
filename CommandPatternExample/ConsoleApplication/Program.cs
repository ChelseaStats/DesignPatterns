using System;
using System.Globalization;
using CommandPatternExample;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Command Pattern Knowledge Share";

            Console.WriteLine("The participants of a command pattern");
            Console.WriteLine("1 Invoker - thing making a request : Customer");
            Console.WriteLine("2 Concrete commands : add, remove, modify");
            Console.WriteLine("3 Abstract command (execution of concrete commands");
            Console.WriteLine("4 Receiver - thing getting a request : A food order in this example");
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("New Order: \n -----");

            var customer = new Customer();
            customer.SetCommand(1 /*Add*/);
            customer.SetMenuItem(new MenuItem("French Fries", 2, 2));
            customer.ExecuteCommand();
            customer.SetCommand(1 /*Add*/);
            customer.SetMenuItem(new MenuItem("Hamburger", 2, 3));
            customer.ExecuteCommand();
            customer.SetCommand(1 /*Add*/);
            customer.SetMenuItem(new MenuItem("Drink", 2, 1));
            customer.ExecuteCommand();
            customer.ShowCurrentOrder();
            Console.WriteLine("Total to pay: £" + customer.GetTotal().ToString(CultureInfo.InvariantCulture));


            Console.ReadKey();
            Console.Clear();
            //Remove the french fries
            customer.SetCommand(3 /*Remove*/);
            customer.SetMenuItem(new MenuItem("French Fries", 2, 2));
            customer.ExecuteCommand();
            Console.WriteLine("Remove fries command");
            Console.WriteLine("\n --------- \n Current order: \n -------");
            customer.ShowCurrentOrder();
            Console.WriteLine("Total to pay: £" + customer.GetTotal().ToString(CultureInfo.InvariantCulture));


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Now we want 4 hamburgers rather than 2");
            //Now we want 4 hamburgers rather than 2
            customer.SetCommand(2 /*Edit*/);
            customer.SetMenuItem(new MenuItem("Hamburger", 4, 3));
            customer.ExecuteCommand();
            Console.WriteLine("\n --------- \n Current order: \n -------");
            customer.ShowCurrentOrder();
            Console.WriteLine("Total to pay: £" + customer.GetTotal().ToString(CultureInfo.InvariantCulture));

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Pros");
            Console.WriteLine("---");
            Console.WriteLine("* Simple to implement, one of the easiest to learn");
            Console.WriteLine("* Observing open/closed principle");
            Console.WriteLine("\n\n");

            Console.WriteLine("Cons");
            Console.WriteLine("---");
            Console.WriteLine("* Probably shouldn't use in the real world - see CQS* pattern and CQRS* (as used in Data Futures)");
            Console.WriteLine("* Separation of command - void methods/actions (can mutate state) and queries - reading from the database (should not mutate state)");
            Console.WriteLine("\n\n");

            Console.WriteLine("Summary");
            Console.WriteLine("---");
            Console.WriteLine("We saw a brief formal introduction of the Command Pattern and then we had a look at a concrete problem that this construct is a natural fit for. Another example would be working with a database.");
            Console.WriteLine("\n\n");
            Console.ReadKey();


        }
    }
}
