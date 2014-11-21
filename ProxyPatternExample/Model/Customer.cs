using System;

namespace ProxyPatternExample
{
    public class Customer
    {
        public int Id { get; set; }

        public Customer(int id)
        {
            Id = id;
            var customerEntity = new CustomerRepository().GetById(id);
            this.Name = customerEntity.Name;
        }

        public string Name { get; set; }
    }

    public class CustomerRepository
    {
        public CustomerEntity GetById(int id)
        {
            Console.WriteLine("--> Fetching Customer "+id);
            return new CustomerEntity()
            {
                Name = "Customer "+id
            };
        }
    }

    public class CustomerEntity
    {
        public string Name { get; set; }
    }
}