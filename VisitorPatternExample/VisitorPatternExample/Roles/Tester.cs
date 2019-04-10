using VisitorPatternExample.Element;

namespace VisitorPatternExample.Roles
{
    class Tester : Employee
    {
        public Tester(string name = null) : base("WhatsMyName", 25000, 25)
        {
            if (name != null) this.Name = name;

            WriteDetails(this);
        }
    }
}