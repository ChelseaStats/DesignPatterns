using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternExample.Element;
using VisitorPatternExample.Roles;
using VisitorPatternExample.Visitor;

namespace VisitorPatternExample
{
    class Program
    {
        /// <summary>
        /// The Visitor pattern represents an operation to be performed on the elements of an object structure.
        /// Whereas Strategy exposes items to a standardized interface, Visitor details a mechanism by which
        /// objects can accept a reference to another object (the visitor) which exposes an interface that the target
        /// can call upon itself.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;



            Console.WriteLine("Let's create some new employees...");
            Console.WriteLine();
            Console.ReadKey();
            // Who are my employees?
            Employees e = new Employees();
            e.Attach(new Tester("Bernadette"));
            e.Attach(new Developer("Howard"));
            e.Attach(new Developer("Rajesh"));
            e.Attach(new LeadDeveloper("Sheldon"));
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Along comes a Visitor to give everyone a pay rise...(JISC?)...");
            Console.WriteLine();
            Console.ReadKey();
            // Employees are visited, giving them raises and 3 extra paid time off days.
            e.Accept(new IncomeVisitor());
            Console.ReadKey();
            Console.WriteLine("Now another Visitor gives everyone some extra leave...");
            Console.WriteLine();
            Console.ReadKey();
            e.Accept(new PaidTimeOffVisitor());

            Console.ReadKey();

            Console.WriteLine("Now we employee a new boss...");
            Console.WriteLine();
            Console.ReadKey();

            Employees e2 = new Employees();
            e2.Attach(new Head("Penny"));
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("A different Visitor gives our new boss a BIG pay rise...Booooo!");
            Console.WriteLine();
            Console.ReadKey();
            e2.Accept(new BigIncomeVisitor());

            Console.ReadKey();
        }
    }
}