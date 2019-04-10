using System;
using CommandPatternExample;
using NUnit.Framework;

namespace CommandPatternTests
{
    
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void Command_Add_ReturnsExpectedTotal()
        {
            var customer = new Customer();
            customer.SetCommand(1);
            customer.SetMenuItem(new MenuItem("French Fries", 2, 2.0));
           
            Assert.DoesNotThrow(customer.ExecuteCommand);
            Assert.AreEqual(4.0, customer.GetTotal());
        }

        [Test]
        public void Command_AddThenModify_ReturnsExpectedTotal()
        {
            var customer = new Customer();
            customer.SetCommand(1);
            customer.SetMenuItem(new MenuItem("Test", 4, 2.5));
            Assert.DoesNotThrow(customer.ExecuteCommand);
            Assert.AreEqual(10.0, customer.GetTotal());

            customer.SetCommand(2);
            customer.SetMenuItem(new MenuItem("Test", 1, 2.5));
            Assert.DoesNotThrow(customer.ExecuteCommand);


            Assert.AreEqual(2.5, customer.GetTotal());
        }

        [Test]
        public void Command_Remove_ItemThatIsNotAlreadyOnList_ThrowsException()
        {
            var customer = new Customer();
            customer.SetCommand(3);
            customer.SetMenuItem(new MenuItem("Test", 5, 5));

            var exception =  Assert.Throws<InvalidOperationException>(() => { customer.ExecuteCommand(); });
            Assert.AreEqual("Sequence contains no matching element", exception.Message);
            Assert.AreEqual(0, customer.GetTotal());
        }
    }
}
