﻿using System;
using System.Globalization;

namespace CommandPatternExample
{
    /// <summary>
    /// Represents an item being ordered from this restaurant.
    /// </summary>
    public class MenuItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Amount: " + Amount);
            Console.WriteLine("Price: £" + Price.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Sub-total: £" + (Price * Amount).ToString(CultureInfo.InvariantCulture));
        }
    }
}
