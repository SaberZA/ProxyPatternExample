using System;
using System.Collections.Generic;

namespace ProxyPatternExample
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int id)
        {
            Id = id;
            GetEntity();
            OrderDate = OrderEntity.OrderDate;
            Customer = GetCustomer();
            Items = GetItems();
        }

        public virtual List<OrderDetails> Items { get; set; }
        public List<int> OrderDetailIds { get; set; }
        public int CustomerId { get; set; }
        public OrderEntity OrderEntity { get; set; }
        public int Id { get; protected set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual List<OrderDetails> GetItems()
        {
            var items = new List<OrderDetails>();
            foreach (int orderDetailId in OrderEntity.OrderDetails)
            {
                items.Add(new OrderDetails(orderDetailId));
            }
            return items;
        }

        public virtual Customer GetCustomer()
        {
            return new Customer(OrderEntity.CustomerId);
        }

        public virtual void GetEntity()
        {
            OrderEntity = new OrderRepository().GetById(Id);
        }
    }
}