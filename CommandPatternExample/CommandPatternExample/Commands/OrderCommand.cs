using System.Collections.Generic;

namespace CommandPatternExample.Commands
{
/// <summary>
/// The Command abstract class
/// </summary>
public abstract class OrderCommand
{
    public abstract void Execute(List<MenuItem> order, MenuItem newItem);
}
}
