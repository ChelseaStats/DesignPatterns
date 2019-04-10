using VisitorPatternExample.Element;

namespace VisitorPatternExample.Roles
{
    class Head : Employee
    {
        public Head(string name = null) : base("WhatsMyName", 50000, 30)
        {
            if (name != null) this.Name = name;

            WriteDetails(this);
        }
    }
}