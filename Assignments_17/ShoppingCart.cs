using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    public class ShoppingCart
    {
        string product_name;
        int product_price;
        int total_units_purchased;
        int discount;

        public void GetDetails()
        {
            Console.WriteLine("Enter the Name of the Product:");
            product_name = Console.ReadLine();

            Console.WriteLine("Enter the Price of the Product:");
            product_price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total units Purchased:");
            total_units_purchased = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayBill()
        {
            if (product_price > 5000 && product_price < 10000)
            {
                discount = product_price - (product_price / 10);
                Console.WriteLine($"Your Total bill is: Rs.{discount}");
                Console.WriteLine("Congrats! You got 10% Discount on your Final Bill.");

            }
            else if(product_price > 2500 && product_price < 5000)
            {
                discount = product_price - (product_price / 5);
                Console.WriteLine($"Your Total bill is: Rs.{discount}");
                Console.WriteLine("Congrats! You got 5% Discount on your Final Bill.");
            }
            else
            {
                Console.WriteLine($"Your Total bill is: Rs.{product_price}");
            }
        }
    }

    public class ShoppingCart2
    {
        public void Show()
        {
            Console.WriteLine("This is a Shopping Cart2 Function");
        }
    }
}
