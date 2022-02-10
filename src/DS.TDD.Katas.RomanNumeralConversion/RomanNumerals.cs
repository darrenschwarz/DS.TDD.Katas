using System.Globalization;
using System.Text;

namespace DS.TDD.Katas.RomanNumeralConversion
{
    public class RomanNumerals
    {
        public static string FromInteger(int integer)
        {
            var converted = new StringBuilder();

            for (int i = 0; i < integer; i++)
            {
                converted.Append("I");
            }
            
            return converted.ToString() ;
        }
    }
}