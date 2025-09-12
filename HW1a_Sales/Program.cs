// HW1a Sales Total

// Your Name: Riley Blackford
// Did you seek help ? If yes, specify the helper or web link here: N/A

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define to convert string into double//
            double num1;
            double num2;

            //defined to make values in formula//
            double subtotal;
            double tax;
            double subtotalwtax;

            //defined so uses can input their number//
            string quantity;
            string product_name;
            string price;

            //defined tax constant tax rate//
            const double multiplier = .085;

            //output to users to input their product name and prices//
            Console.WriteLine("What is the product name of the item you are purchasing?");
            product_name = Console.ReadLine();
            Console.WriteLine("How many " + product_name + "'s do you want to buy?");
            quantity = Console.ReadLine();
            Console.WriteLine("What is the price for each " + product_name +"?");
            price = Console.ReadLine();

            //convert string to double//
            num1 = Convert.ToDouble(quantity);
            num2 = Convert.ToDouble(price);

            //formulas to find the subtotal, amount of tax, and subtotal with tax//
            subtotal = num1 * num2;
            tax = multiplier * subtotal;
            subtotalwtax = tax + subtotal;

            //output to user//
            Console.WriteLine($"Your subtotal for your bill is ${subtotal}.");
            Console.WriteLine($"Your sales tax for your bill is ${tax}." );
            Console.WriteLine($"You total for your bill is ${subtotalwtax}.");

            Console.ReadKey();
        }
    }
}
