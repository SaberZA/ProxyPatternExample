using System;
using System.Collections.Generic;

namespace ProxyPatternExample
{
    public class OrderEntity
    {
        public int CustomerId { get; set; }
        public IEnumerable<int> OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
        public int Id { get; set; }
    }
}