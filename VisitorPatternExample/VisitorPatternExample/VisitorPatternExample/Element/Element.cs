using VisitorPatternExample.Visitor;

namespace VisitorPatternExample.Element
{
    /// <summary>
    /// The Element abstract class.  All this does is define an Accept operation, which needs to be implemented by any class that can be visited.
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}