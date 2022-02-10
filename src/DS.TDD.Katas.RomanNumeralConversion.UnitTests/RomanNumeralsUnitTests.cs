using Xunit;

namespace DS.TDD.Katas.RomanNumeralConversion.UnitTests
{
    public class RomanNumeralsUnitTests
    {
        [Theory]
        [InlineData(1, "I")]
        public void IntegerIsConvertedToRomanNumerals(int integer, string romanNumerals)
        {
            Assert.True(romanNumerals.Equals(RomanNumerals.FromInteger(integer)));
        }
    }
}