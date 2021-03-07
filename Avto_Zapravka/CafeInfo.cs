namespace Avto_Zapravka
{
    public class CafeInfo
    {
        public CafeInfo(string product, decimal price)
        {
            Product = product;
            Price = price;
            Count = default;
        }

        public string Product { get; }
        public decimal Price { get; set; } 
        public int Count { get; set; }
        public decimal Suma { get; set; } 
    }
}