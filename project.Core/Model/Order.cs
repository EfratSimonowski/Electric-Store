namespace project.Core.Model
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateOrder {  get; set; }
        public double TotalPrice {  get; set; }



    }
}
