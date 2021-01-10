using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    public static class InputUser

    {
        static Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

        private static string ValueString { get; set; }
        private static string Value1 { get; set; }
        private static string Value2 { get; set; }
        public static double Primer()
        {
            Value1 = StringDouble();
            Func<String, double> Operation = MatemOperation();
            Value2 = StringDouble();
            return (double)(Operation?.Invoke(Value1, Value2));

        }

        public static Func<String, double> MatemOperation()
        {
            Console.WriteLine("\nВыбрать нужную операцию подсчета (+, -, *, /)");
            bool checkSelect = false;
            Func<String, double> Operation = null;
            char chr;
            do
            {
                chr = Console.ReadKey(true).KeyChar;
                switch (chr)
                {
                    case '+':
                        {
                            Console.Write(" + ");
                            checkSelect = true;
                            Operation = Calculator.Add2;
                        }
                        break;
                    case '-':
                        {
                            Console.Write(" - ");
                            checkSelect = true;
                            Operation = Calculator.Subtract2;
                        }
                        break;
                    case '*':
                        {
                            Console.Write(" * ");
                            checkSelect = true;
                            Operation = Calculator.Multiply2;
                        }
                        break;
                    case '/':
                        {
                            Console.Write(" / ");
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
            ValueString = "";
            ConsoleKeyInfo consoleKeyInfo;
            Console.WriteLine("Введите число ");

            do
            {
                consoleKeyInfo = Console.ReadKey(true);
                keypress = consoleKeyInfo.KeyChar;
                if (((int)keypress >= 48 & (int)keypress <= 58))
                {
                    ValueString += keypress;
                    Console.Write(keypress);
                }
                if (!existMinus && consoleKeyInfo.Key.Equals(ConsoleKey.OemMinus) && ValueString.Length == 0)
                {
                    ValueString += '-';
                    existMinus = true;
                    Console.Write('-');
                }
                if (!existSeparator
                    && (consoleKeyInfo.Key.Equals(ConsoleKey.OemComma)
                    || consoleKeyInfo.Key.Equals(ConsoleKey.OemPeriod)))
                //  if (!existSeparator && (keypress.Equals(',') || keypress.Equals('.')))
                {
                    ValueString += separator;
                    existSeparator = true;
                    Console.Write(separator);
                }
                if (consoleKeyInfo.Key.Equals(ConsoleKey.Backspace) && ValueString.Length > 0)
                {
                    ValueString = ValueString.Remove(ValueString.Length - 1);
                    Console.Write($"\r{ValueString} ");

                }

            } while (!consoleKeyInfo.Key.Equals(ConsoleKey.Spacebar) &&
            !consoleKeyInfo.Key.Equals(ConsoleKey.Enter));

            return ValueString.Length == 0 ? "0" : ValueString;
        }


    }
}
