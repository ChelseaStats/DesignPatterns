using CommandPatternExample.Commands;

namespace CommandPatternExample
{
    public class CommandFactory
    {
        /// <summary>
        /// Factory method to handle different commands
        /// </summary>
        /// <param name="commandOption"></param>
        /// <returns></returns>
        public OrderCommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new ModifyCommand();
                case 3:
                    return new RemoveCommand();
                default:
                    return new AddCommand();
            }
        }
    }
}
