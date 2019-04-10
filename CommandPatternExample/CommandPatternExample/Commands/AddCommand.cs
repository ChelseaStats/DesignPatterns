using System.Collections.Generic;

namespace CommandPatternExample.Commands
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Add(newItem);
        }
    }
}