using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    public static class DataInput
    {
        static Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

        public static string StringDidital { get; set; }
        public static string StringPhrase { get; set; }
        public static String InPhrase()
        {
            Console.WriteLine();
            StringPhrase = Console.ReadLine();



            return StringPhrase;
        }
        public static String StringDouble()
        {
            char keypress;
            bool existSeparator = false;
            StringDidital = default;
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey();
                keypress = consoleKeyInfo.KeyChar;
                if (((int)keypress >= 48 & (int)keypress <= 59) || consoleKeyInfo.Key.Equals(ConsoleKey.OemMinus))
                {
                    StringDidital += keypress;
                }
                if (!existSeparator
                    && (consoleKeyInfo.Key.Equals(ConsoleKey.OemComma)
                    || consoleKeyInfo.Key.Equals(ConsoleKey.OemPeriod)))

                //  if (!existSeparator && (keypress.Equals(',') || keypress.Equals('.')))
                {
                    StringDidital += separator;
                    existSeparator = true;
                }
            } while (!consoleKeyInfo.Key.Equals(ConsoleKey.Enter));//(!keypress.Equals('\r'));

            Console.WriteLine("\n" + StringDidital);
            return StringDidital;
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
