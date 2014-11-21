using System;

namespace ProxyPatternExample
{
    public class DisplayDetails
    {
        public static void Display(Order order)
        {
            Console.WriteLine("Displaying Order Information");
            Console.WriteLine("Order Date: "+ order.OrderDate.Date);
            Console.WriteLine("Customer: "+ order.Customer.Name);
            foreach (var item in order.Items)
            {
                Console.WriteLine("Item: "+item.Name);
            }
        }
    }
}