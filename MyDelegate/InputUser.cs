using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    public static class InputUser

    {
        static Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
        //   static LinkedList<decimal> Phrases = new LinkedList<decimal> { };
        public static string StringDidital { get; set; }
        public static string StringPhrase { get; set; }
        public static decimal InPhrase()
        {
            Console.WriteLine();
            // StringPhrase = Console.ReadLine();

            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Введено не число, по умолчанию присвоено {result}," +
                    $"\n дробную часть надо отделять ( {separator} ) знаком");
                InPhrase();
            }


            return result;
        }
        public static Func<String, double> MatemOperation()
        {
            Console.WriteLine("выбрать нужную операцию подсчета (+, -, *, /)");
           // ConsoleKeyInfo consoleKeyInfo;
            bool checkSelect = false;
            Func<String, double> Operation = null;
            do
            {
                  char chr = Console.ReadKey(true).KeyChar;
                switch (chr)
                {
                    case '+':
                        {
                            Console.WriteLine(" + ");
                            checkSelect = true;
                             Operation = Calculator.Add2;

                        }
                        break;
                    case '-':
                        {
                            Console.WriteLine(" - ");
                            checkSelect = true;
                            Operation = Calculator.Subtract2;

                        }

                        break;
                    case '*':

                        {
                            Console.WriteLine(" * ");
                            checkSelect = true;
                            Operation = Calculator.Multiply2;

                        }

                        break;
                    case '/':
                        {
                            Console.WriteLine(" / ");
                            checkSelect = true;
                             Operation = Calculator.Divide2;

                        }

                        break;
                    default:
                        break;
                }

            } while (!checkSelect);

            return Operation;
        }
        public static String StringDouble()
        {
            char keypress;
            bool existSeparator = false;
            bool existMinus = false;
            StringDidital = "";
            ConsoleKeyInfo consoleKeyInfo;
            Console.WriteLine(" Введите число ");

            do
            {
                consoleKeyInfo = Console.ReadKey(true);
                keypress = consoleKeyInfo.KeyChar;
                if (((int)keypress >= 48 & (int)keypress <= 58))
                {
                    StringDidital += keypress;
                    Console.Write(keypress);
                }
                if (!existMinus && consoleKeyInfo.Key.Equals(ConsoleKey.OemMinus) && StringDidital.Length == 0)
                {
                    StringDidital += '-';
                    existMinus = true;
                    Console.Write('-');
                }
                if (!existSeparator
                    && (consoleKeyInfo.Key.Equals(ConsoleKey.OemComma)
                    || consoleKeyInfo.Key.Equals(ConsoleKey.OemPeriod)))

                //  if (!existSeparator && (keypress.Equals(',') || keypress.Equals('.')))
                {
                    StringDidital += separator;
                    existSeparator = true;
                    Console.Write(separator);
                }
              //  Console.Write(StringDidital);
            } while (!consoleKeyInfo.Key.Equals(ConsoleKey.Enter));//(!keypress.Equals('\r'));
            Console.WriteLine($"Вы ввели { StringDidital}");
            //  Console.WriteLine("\n" + StringDidital);
            return StringDidital.Length == 0 ? "0" : StringDidital;
        }

        /*
                public double InDouble()
                {
                    if (double.TryParse(Console.ReadLine(), out double value))
                    {
                        return value;
                    }
                    else
                    {
                        return value = default;
                    }



                }
        */
    }
}
