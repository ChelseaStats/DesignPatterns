using System;
using Humanizer;
using VisitorPatternExample.Visitor;

namespace VisitorPatternExample.Element
{
    /// <summary>
    /// The Concrete Element class, which implements all operations defined by the Element.
    /// </summary>
    class Employee : Element
    {
        public string Name { get; set; }
        public double AnnualSalary { get; set; }
        public int PaidTimeOffDays { get; set; }

        public Employee(string name, double annualSalary, int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        public void WriteDetails(Employee e)
        {
            Console.WriteLine($"{e.GetType().Name} {e.Name} has joined HESA with a starting salary of {e.AnnualSalary:C} and {e.PaidTimeOffDays.ToWords()} days leave.");
        }


        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}