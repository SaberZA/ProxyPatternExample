using System;

namespace ProxyPatternExample
{
    public class OrderDetailsRepository
    {
        public OrderDetailsEntity GetById(int id)
        {
            Console.WriteLine("--> Fetch Order Details Item "+id);
            new Random().Next(5, 20);
            
            return new OrderDetailsEntity()
            {
                Name = "Product "+id,
                Price = new Random().Next(5, 20)
            };
        }
    }
}