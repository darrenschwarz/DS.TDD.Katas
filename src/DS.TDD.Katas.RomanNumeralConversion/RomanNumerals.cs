using System.Globalization;
using System.Text;

namespace DS.TDD.Katas.RomanNumeralConversion
{
    public class RomanNumerals
    {
        public static string FromInteger(int integer)
        {
            var converted = new StringBuilder();

            if (integer >= 2)
            {
                converted.Append("I");
            }

            converted.Append("I");

            return converted.ToString() ;
        }
    }
}