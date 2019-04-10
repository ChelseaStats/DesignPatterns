using System;
using VisitorPatternExample.Element;

namespace VisitorPatternExample.Roles
{
    class Developer : Employee
    {
        public Developer(string name = null) : base("WhatsMyName", 30000, 25)
        {
           if (name != null) this.Name = name;
           WriteDetails(this);
        }
    }
}