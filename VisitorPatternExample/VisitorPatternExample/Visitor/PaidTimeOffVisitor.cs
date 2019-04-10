using System;
using Humanizer;
using VisitorPatternExample.Element;

namespace VisitorPatternExample.Visitor
{
    /// <summary>
    /// A Concrete Visitor class
    /// </summary>
    class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element.Element element)
        {
            Employee employee = element as Employee;

            // And because you all helped have such a great year, all my employees get three extra paid time off days each!
            employee.PaidTimeOffDays += 3;
            Console.WriteLine("{0} {1}'s new annual leave entitlement: {2}", employee.GetType().Name, employee.Name, employee.PaidTimeOffDays.ToRoman());
        }
    }
}