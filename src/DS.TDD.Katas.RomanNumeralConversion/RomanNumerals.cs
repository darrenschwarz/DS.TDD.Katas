using System.Globalization;
using System.Text;

namespace DS.TDD.Katas.RomanNumeralConversion
{
    public class RomanNumerals
    {
        private static List<int> _integers = new List<int>(){40, 10, 9, 5, 4, 1};
        private static List<string> _romanNumerals = new List<string>() { "XL", "X", "IX", "V", "IV", "I" };

        public static string FromInteger(int integer)
        {
            var converted = new StringBuilder();
            var integerToConvert = integer;

            for (int i = 0; i < _integers.Count; i++)
            {
                integerToConvert = AppendToConverted(converted, integerToConvert, _integers[i], _romanNumerals[i]);
            }

            return converted.ToString() ;
        }

        public static int AppendToConverted(StringBuilder converted, int integerToConvert, int integer, string romanNumeral)
        {
            var currentIntegerToConvert = integerToConvert;

            while (currentIntegerToConvert >= integer)
            {
                converted.Append(romanNumeral);
                currentIntegerToConvert -= integer;
            }

            return currentIntegerToConvert;
        }

        
    }
}