using System;
using Xunit;
using CalculatorLibrary;
namespace Calculators.Test
{
    public class CalculatorTest
    {

        [Fact]
        public void Add_Signature()
        {
            var calculator = new Calculator();
            string numbers = string.Empty;
            calculator.Add(numbers);
        }

        [Fact]
        public void Add_Empty_Parameters()
        {
            var calculator = new Calculator();
            var input = string.Empty;
            int result = calculator.Add(input);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("5", 5)]
        [InlineData("55", 55)]
        public void Add_Single_Parameters(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("5,7", 12)]
        [InlineData("55, 1", 56)]
        public void Add_Two_Parameters(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("5,7,1,1", 14)]
        [InlineData("55,1,1,1,1", 59)]
        public void Add_Many_Parameters(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1\n2,4", 7)]
        [InlineData("5,5,1\n1", 12)]
        public void Add_New_Line_Delimiter(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n1;9", 10)]
        [InlineData("//*\n5*5*1*2", 13)]
        public void Add_Changed_Delimiter(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("-50")]
        [InlineData("-1,9")]
        [InlineData("20,-1,5")]
        public void Add_Throws_Negative_Numbers(string input)
        {
            var calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => calculator.Add(input));
        }

        [Theory]
        [InlineData("-60", "-60")]
        [InlineData("-2,9", "-2")]
        [InlineData("20,5,-15,-40", "-15, -40")]

        public void Add_Throws_Negative_Numbers_Specifying_Them(string input, string negativeNumbers)
        {
            var calculator = new Calculator();
            var exception = Assert.Throws<ArgumentException>(() => calculator.Add(input));

            var expectedExceptionMessage = $"negatives not allowed: {negativeNumbers}";

            Assert.Equal(expectedExceptionMessage, exception.Message);
        }



        [Theory]
        [InlineData("2,1001", 2)]
        [InlineData("1001,5,20000", 5)]
        public void Add_More1000(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        
         [Theory]
        [InlineData("//[***]\n1***2***3", 6)]
        [InlineData("//[####]\n1####2####4", 7)]
        [InlineData("//[^^^^^]\n5^^^^^2^^^^^4", 11)]
        public void Add_Delimeter_l(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//[*][%]\n1*2%3",6)]
        [InlineData("//[***][####]\n3***2####3", 8)]
        [InlineData("//[####][^^^^^]\n6####2^^^^^4", 12)]
        [InlineData("//[^^^^^][&&&][*][%]\n8&&&2%1*2%3^^^^^4", 20)]
        public void Add_More_One_Delimeter_l(string input, int expectedResult)
        {
            var calculator = new Calculator();
            int result = calculator.Add(input);
            Assert.Equal(expectedResult, result);
        }

        /*
                [Fact]
                public void Add_Signature()
                {
                    var Calculator = new Calculator();
                    string nambers = string.Empty;
                    int resalt= Calculator.Add(nambers);

                }
              *//*  [Theory]
                [InlineData("")]
                [InlineData("1")]

                public void Add_Up_To_Two_Parameters(string input)
                {
                    var Calculator = new Calculator();
                    int resalt = Calculator.Add(input);
                    Assert.Equal(0, resalt);
                }*//*

                [Fact]
                public void Add_Up_To_Two_Parameters()
                {
                    var Calculator = new Calculator();

                    string input = string.Empty;
                    int resalt = Calculator.Add(input);
                    Assert.Equal(0, resalt);

                     input = "";
                     resalt = Calculator.Add(input);
                    Assert.Equal(0, resalt);

                    input = "1";
                    resalt = Calculator.Add(input);
                    Assert.Equal(1, resalt);

                    input = "1,2";
                    resalt = Calculator.Add(input);
                    Assert.Equal(3 , resalt);

                    input = "5,8";
                    resalt = Calculator.Add(input);
                    Assert.Equal(13, resalt);


                    input = "2,2,2,2,2,8";
                    resalt = Calculator.Add(input);
                    Assert.Equal(18, resalt);

                    input = "0,,11";
                    resalt = Calculator.Add(input);
                    Assert.Equal(11, resalt);

                    input = ",,,,";
                    resalt = Calculator.Add(input);
                    Assert.Equal(0, resalt);

                    input = null;
                    resalt = Calculator.Add(input);
                    Assert.Equal(0, resalt);
                }
                [Theory]
                [InlineData("1\n2, 3", 6)]
                [InlineData("//;\n1;2", 3)]
                [InlineData("1001,2", 2)]
                [InlineData("//[***]\n1***2***3", 6)]
                [InlineData("//[*][%]\n1*2%3", 6)]


                public void Add_New_Line_Delimiter(string input, int exeptedResult)
                {
                    var Calculator = new Calculator();

                    int resalt = Calculator.Add(input);
                    Assert.Equal(exeptedResult, resalt);
                }
                ////;\n1;2
                ///
        */
    }
}
