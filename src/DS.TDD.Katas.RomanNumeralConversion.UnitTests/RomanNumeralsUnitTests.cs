using Xunit;

namespace DS.TDD.Katas.RomanNumeralConversion.UnitTests
{
    public class RomanNumeralsUnitTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        public void IntegerIsConvertedToRomanNumerals(int integer, string romanNumerals)
        {
            Assert.True(romanNumerals.Equals(RomanNumerals.FromInteger(integer)));
        }
    }
}