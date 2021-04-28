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
    class ProviderProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
