using System.Collections.Generic;
using System.Linq;

namespace CommandPatternExample.Commands
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class RemoveCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Remove(currentItems.First(x => x.Name == newItem.Name));
        }
    }
}