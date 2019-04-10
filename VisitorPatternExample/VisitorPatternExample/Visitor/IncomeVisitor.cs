using System;
using System.ComponentModel;
using VisitorPatternExample.Element;
using Humanizer;

namespace VisitorPatternExample.Visitor
{
    /// <summary>
    /// A Concrete Visitor class.
    /// </summary>
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            double increment = 1.2;

            Employee employee = element as Employee;
         
            if (employee.GetType().Name == "Tester")
            {
               increment = 1.3;
            }



            // We've had a great year, so pay raises for everyone!
            employee.AnnualSalary *= increment;

            Console.WriteLine($"{employee.GetType().Name.Humanize()} {employee.Name}'s new income: {employee.AnnualSalary:C} with a {increment} uplift.");
        }
    }
}