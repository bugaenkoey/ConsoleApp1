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
    public delegate TResult Func<T1, TResult>(T1 arg1, T1 arg2);
    public delegate TResult Func<TResult>();

    class Program
    {
        static void Main(string[] args)
        {
            //           Func<string> StringValue = InputUser.StringDouble;
            Console.WriteLine("\nЗапишите простой пример -2 * -3");
            do
            {
                Console.WriteLine("пример");
                Console.WriteLine($"\nРезультат { InputUser.Primer()}");
                Console.WriteLine("Для выхода нажмите ESC , для продолжения любую кнопку ");
            } while (!Console.ReadKey(true).Key.Equals(ConsoleKey.Escape));
            /*
                        do
                        {
                            Func<String, double> Operation = InputUser.MatemOperation();
                            //  Console.WriteLine(Operation?.Invoke(InputUser.StringDouble(), InputUser.StringDouble()));
                            Console.WriteLine($" Результат {Operation?.Invoke(StringValue(), StringValue())}");
                            Console.WriteLine("Для выхода нажмите ESC , для продолжения любую кнопку ");
                        } while (!Console.ReadKey().Key.Equals(ConsoleKey.Escape));
            */
            {
                /*

                            Console.WriteLine(Calculator.Add2(DataInput.StringDouble(), DataInput.StringDouble()));
                            Console.WriteLine(Calculator.Subtract2(DataInput.StringDouble(), DataInput.StringDouble()));
                            Console.WriteLine(Calculator.Multiply2(DataInput.StringDouble(), DataInput.StringDouble()));
                            Console.WriteLine(Calculator.Divide2(DataInput.StringDouble(), DataInput.StringDouble()));
                */
            }
        }
    }
}
