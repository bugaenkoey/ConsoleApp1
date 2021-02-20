namespace Avto_Zapravka
{
    public class GasInfo
    {
        public GasInfo(string title, decimal price)
        {
            Title = title;
            Price = decimal.Round( price,2);
        }

        public string Title { get; }
        public decimal Price { get; }
        public override string ToString()
        {
            return Title;
        }
    }
}