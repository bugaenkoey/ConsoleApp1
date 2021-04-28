using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStorage
{
    /*
Создайте многотабличную базу данных «Склад».
Нужно хранить такую информацию:

■ Название товара;
■ Тип товара;
■ Поставщик товара;
■ Количество товара;
■ Себестоимость;
■ Дата поставки.
    */
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
       
        ProviderProduct [] ProviderProduct { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime DateProvide { get; set; }

    }
}
