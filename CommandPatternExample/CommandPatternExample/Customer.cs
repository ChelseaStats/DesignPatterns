using System.Linq;
using CommandPatternExample.Commands;

namespace CommandPatternExample
{
    /// <summary>
    /// The Invoker class
    /// </summary>
    public class Customer
    {
        private OrderCommand _orderCommand;
        private MenuItem _menuItem;
        private readonly FastFoodOrder _order;

        public Customer()
        {
            _order = new FastFoodOrder();
        }

        public void SetCommand(int commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public void ExecuteCommand()
        {
            _order.ExecuteCommand(_orderCommand, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _order.ShowCurrentItems();
        }

        public double GetTotal()
        {
            return _order.currentItems.Sum(t => t.Price * t.Amount);
        }
    }
}