﻿namespace Avto_Zapravka
{
    public class GasInfo
    {
        public GasInfo(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; }
        public decimal Price { get; }
        public override string ToString()
        {
            return Title;
        }
    }
}