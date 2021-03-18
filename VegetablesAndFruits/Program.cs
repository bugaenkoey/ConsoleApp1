using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

namespace VegetablesAndFruits
{
    /**Курс: «Технология доступа
к базам данных ADO.NET
Модуль 1. Введение в ADO.NET. Часть 1

Задание 1
Создайте однотабличную базу данных «Овощи и
фрукты». Нужно хранить такую информацию:
■ Название;
■ Тип (овощ или фрукт);
■ Цвет;
■ Калорийность.
Задание 2
Создайте приложение, которую позволит пользователю подключиться 
и отключиться от базы данных «Овощи и фрукты». 
В случае успешного подключения выводите информационное сообщение. 
Если подключение было неуспешным, сообщите об ошибке. 
Приложение может быть консольным или с UI интерфейсом.
Задание 3
Добавьте к приложению из второго задания следующую функциональность:
■ Отображение всей информации из таблицы с овощами и фруктами;
■ Отображение всех названий овощей и фруктов;
■ Отображение всех цветов;
■ Показать максимальную калорийность;
■ Показать минимальную калорийность;
■ Показать среднюю калорийность.
Задание 4
Добавьте к приложению из второго задания следующую функциональность:
■ Показать количество овощей;
■ Показать количество фруктов;
■ Показать количество овощей и фруктов заданного цвета;
■ Показать количество овощей фруктов каждого цвета;
■ Показать овощи и фрукты с калорийностью ниже
указанной;
■ Показать овощи и фрукты с калорийностью выше
указанной;
■ Показать овощи и фрукты с калорийностью в указанном диапазоне;
■ Показать все овощи и фрукты, у которых цвет желтый
или красный.
*/
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

         /*   var connectionString = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=VegetablesFruits;Integrated Security=True;";
           // connectionString = @"Data xxx;";
            // dbConnection.ConnectionString = connectionString;

            try
            {
            DbConnection dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();


                MessageBox.Show("Подключение!", "Ок");*/

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
          /*}
            catch
            {
                MessageBox.Show("Нет связи с БД!", "Ошибка подключения",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/



        }
    }
}
