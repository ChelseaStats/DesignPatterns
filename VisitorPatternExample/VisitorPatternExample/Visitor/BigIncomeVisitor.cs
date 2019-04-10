using System;
using VisitorPatternExample.Element;

namespace VisitorPatternExample.Visitor
{
    /// <summary>
    /// A Concrete Visitor class.
    /// </summary>
    class BigIncomeVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            Employee employee = element as Employee;

            // We've had a great year, so pay raises for everyone!
            employee.AnnualSalary *= 1.5;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.AnnualSalary:C} after a 1.5 uplift as a bonus.");
        }
    }
}