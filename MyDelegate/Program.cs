using System;

namespace MyDelegate
{/*Задание 1:
  * Написать консольное приложение калькулятора, 
  * которое работает с операциями основными математическими операциями
  * (+, -, *, /)
  * Реализовать в приложении класс Calculator,
  * который будет содержать в себе методы указанных операций,
  * например: double Add(double x, double y) 
  * Также, при написании выделить в отдельный класс
  * работу пользователя с калькулятором через консоль 
  * (получение значений и информирование пользователя), 
  * который помимо всего, будет предлагать пользователю 
  * выбрать нужную операцию подсчета и в зависимости от выбора,
  * используя встроенный делегат Func для хранения ссылки 
  * на метод выбранной операции, выводить её результат.
  * 
  */
    class Program
    {
        static void Main(string[] args)
        {
            //  Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            //  Console.WriteLine(separator);

            Console.WriteLine(DataInput.InPhrase());

            Console.WriteLine(Calculator.Add2(DataInput.StringDouble(), DataInput.StringDouble()));
            Console.WriteLine(Calculator.Subtract2(DataInput.StringDouble(), DataInput.StringDouble()));
            Console.WriteLine(Calculator.Multiply2(DataInput.StringDouble(), DataInput.StringDouble()));
            Console.WriteLine(Calculator.Divide2(DataInput.StringDouble(), DataInput.StringDouble()));

        }
    }
}
