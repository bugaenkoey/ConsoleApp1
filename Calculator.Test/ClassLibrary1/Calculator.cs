using System;
using System.Linq;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public Calculator()
        {
        }
        /**6.	Числа больше 1000 должны игнорироваться, так что 2 + 1001 = 2
7.	Разделитель может быть произвольной длины, и задаваться следующим образом:
"//[delimiter]\n", например: "//[***]\n1***2***3" должно вернуть 6.
8.	Добавить поддержку нескольких разделителей, которые задаются следующим образом:
"//[delim1][delim2]\n", например "//[*][%]\n1*2%3" должно вернуть 6.
        */

        /*   public struct DelimeterStructura
           {
               public int startIndex { get; set; }
               public int endIndex { get; set; }
           }*/


        internal int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }


            if (numbers.StartsWith("//["))
            {
                return MoreDelimiter(numbers);
                
            }



            char delimiter = ',';
            if (numbers.StartsWith("//"))
            {
                delimiter = numbers[2];
                numbers = numbers.Substring(4);
            }

            var splitted = numbers.Split(delimiter, '\n');
            if (splitted.Length == 1)
            {
                var result = ParseInt(splitted[0]);
                return result >= 0 ? result : throw new ArgumentException($"negatives not allowed: {result}");
            }

            var parsedNumbers = splitted.Select(ParseInt);

            var negativeNumbers = parsedNumbers.Where(n => n < 0);
            return negativeNumbers.Any()
                ? throw new ArgumentException($"negatives not allowed: {string.Join(", ", negativeNumbers)}")
                : parsedNumbers.Sum();


        }

        private int MoreDelimiter(string numbers)
        {
            /*
                     "//[***][####]\n3***2####3", 8
                     "//[####][^^^^^]\n6####2^^^^^4", 12
                     "//[^^^^^][&&&]\n8&&&2^^^^^4", 14
                     "//[^^^^^][&&&][*][%]\n8&&&2%1*2%3^^^^^4", 20
            */

            string[] stringSeparators = new string[] { "//", "[", "]", ".", "-" };

            var strings = numbers.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            var StringsDelimiter = strings[0].Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            string[] ArrayDidgit = strings[1].Split(StringsDelimiter, StringSplitOptions.RemoveEmptyEntries);


            int resultat = 0;
            for (int i = 0; i < ArrayDidgit.Length; i++)
            {

                resultat += ParseInt(ArrayDidgit[i]);
            }

            return resultat;
        }

        private int ParseInt(string number)
        {
            int n = int.Parse(number);
            return n > 1000 ? 0 : n;
        }

    }
}