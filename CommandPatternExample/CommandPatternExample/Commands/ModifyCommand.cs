using System.Collections.Generic;
using System.Linq;

namespace CommandPatternExample.Commands
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class ModifyCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            var item = currentItems.First(x => x.Name == newItem.Name);
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
        }
    }
}
