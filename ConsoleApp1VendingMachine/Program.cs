﻿using System;

namespace ConsoleApp1VendingMachine
{
    class Program
    {
        //Declaring this variable as a static so we may be able to see ammount entered in the machine all time
        static int pool = 0;
        static void Main(string[] args)
        { 
            IVending VM = new VendingMachine();
            bool ProductMenu = true;
            while(ProductMenu)
            {
                Console.Clear();
                
                Console.WriteLine("Ammount Entered in Machine:{0}", pool);
                Console.WriteLine("Enter 1 To Show All Products");
                Console.WriteLine("Enter 2 To Add Money");
                Console.WriteLine("Enter 3 To Buy A Product");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       
                        break;
                    case 2:
                        Console.WriteLine("Enter Money: 1, 5, 10, 20, 50, 100, 500, 1000");
                        int ammount = Convert.ToInt32(Console.ReadLine());
                        pool = VM.InsertMoney(ammount);
                        Console.WriteLine("Ammount in machine:{0}", pool);
                        Console.ReadLine();
                        break;
                }
            }
            
        }
    }
}
