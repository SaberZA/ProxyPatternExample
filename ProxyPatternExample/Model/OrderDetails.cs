namespace ProxyPatternExample
{
    public class OrderDetails
    {
        public OrderDetails(int id)
        {
            OrderDetailId = id;
            var orderDetailsEntity = new OrderDetailsRepository().GetById(id);
            Name = orderDetailsEntity.Name;
            Price = orderDetailsEntity.Price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int OrderDetailId { get; set; }
    }
}