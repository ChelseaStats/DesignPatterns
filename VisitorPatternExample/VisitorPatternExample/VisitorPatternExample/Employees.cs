using System;
using System.Collections;
using System.Collections.Generic;
using VisitorPatternExample.Element;
using VisitorPatternExample.Visitor;

namespace VisitorPatternExample
{
    /// <summary>
    /// The Object Structure class, which is a collection of Concrete Elements.  This could be implemented using another pattern such as Composite.
    /// </summary>
    class Employees
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var e in _employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}