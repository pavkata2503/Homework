using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_Service
{

    internal class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] parts = input.Split(' ');

                if (parts.Length == 5 && parts[0] == "Pizza")
                {
                    string pizzaType = parts[1];
                    int quantity = int.Parse(parts[2]);
                    string size = parts[3];
                    string date = parts[4];


                    Pizza pizza = PizzaFactory.CreatePizza(pizzaType, quantity, size, date);
                    pizza.Prepare();
                    cashRegister.AddOrder(pizza);
                }
                else
                {
                    Console.WriteLine("Invalid input format");
                }
            }

            cashRegister.DailyReport();
        }
    }
}
