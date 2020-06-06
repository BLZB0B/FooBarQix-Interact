using System;

namespace FooBarQixKataInteract
{
    public class FooBarCalculator
    {
        /*
        If the number is divisible by 3, write “Foo” instead of the number
        If the number is divisible by 5, add “Bar”
        If the number is divisible by 7, add “Qix”
        For each digit 3, 5, 7, add “Foo”, “Bar”, “Qix” in the digits order.
         */
        public string Compute(string input)
        {

            var result = ReplaceByDivisors(input);
            result += ReplaceDigits(input);

            if (string.IsNullOrEmpty(result))
            {
                result = input;
            }

            return result;
        }

        private string ReplaceDigits(string input)
        {
            var result = "";

            foreach (char number in input)
            {
                switch (number)
                {
                    case '3':
                        result += "Foo";
                        break;
                    case '5':
                        result += "Bar";
                        break;
                    case '7':
                        result += "Qix";
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        private string ReplaceByDivisors(string input)
        {
            var result = "";
            var number = Convert.ToInt16(input);

            if (number % 3 == 0)
            {
                result += "Foo";
            }

            if (number % 5 == 0)
            {
                result += "Bar";
            }

            if (number % 7 == 0)
            {
                result += "Qix";
            }

            return result;
        }
    }
}