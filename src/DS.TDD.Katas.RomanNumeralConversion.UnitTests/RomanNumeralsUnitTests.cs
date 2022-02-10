using Xunit;

namespace DS.TDD.Katas.RomanNumeralConversion.UnitTests
{
    public class RomanNumeralsUnitTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        public void IntegerIsConvertedToRomanNumerals(int integer, string romanNumerals)
        {
            Assert.True(romanNumerals.Equals(RomanNumerals.FromInteger(integer)));
        }
    }
}