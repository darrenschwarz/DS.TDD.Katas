using System.Globalization;
using System.Text;

namespace DS.TDD.Katas.RomanNumeralConversion
{
    public class RomanNumerals
    {
        public static string FromInteger(int integer)
        {
            var converted = new StringBuilder();
            var integerToConvert = integer;

            if (integerToConvert >= 4)
            {
                converted.Append("IV");
                integerToConvert -= 4;
            }

            for (int i = 0; i < integerToConvert; i++)
            {
                converted.Append("I");
            }
            
            return converted.ToString() ;
        }
    }
}