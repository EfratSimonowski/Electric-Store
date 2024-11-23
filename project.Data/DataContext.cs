using project.Core.Model;

namespace project.Data
{
    public class DataContext
    {
       public List<Customer> cutomers { get; set; }
        public List<Order> orders { get; set; }
        public List<Product> products { get; set; }
        public DataContext() {

            cutomers = new List<Customer>
        {
                new Customer { CustomerId = "215020819", CustomerName = "chana", Address = "stein", City = "jerusalem", Email = "12345678@gmail.com" }
        };
            orders = new List<Order>
        {
                new Order { OrderId = 1, CustomerId = "123456", DateOrder = new DateTime(), TotalPrice = 120 }
        };
            products = new List<Product>
        {
                new Product { ProductId = "12345", ProductName = "dall", Price = 30, Availability = true }
        };
    }
    }
}
