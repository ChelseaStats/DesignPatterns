using System;
using VisitorPatternExample.Element;

namespace VisitorPatternExample.Visitor
{
    /// <summary>
    /// A Concrete Visitor class.
    /// </summary>
    class PayCutVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            Employee employee = element as Employee;

            // We've had a great year, so 10% pay raises for everyone!
            employee.AnnualSalary *= 0.8;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name, employee.AnnualSalary);
        }
    }
}