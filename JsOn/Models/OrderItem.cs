namespace JsOn.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public Toys Toys { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get; set; }
    }
}
