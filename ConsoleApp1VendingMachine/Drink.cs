﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    class Drink : Product
    {
        public Drink(string productName, decimal price) : base (productName, price)
        {

        }
        public override void Examine()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            Console.WriteLine("Drink Your Drink");
        }
    }
}
