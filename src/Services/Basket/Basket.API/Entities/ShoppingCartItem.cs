namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal price { get; set; }
        public int Quantity { get; set; }
        public string color { get; set; } = string.Empty;
       
       

    }
}