using System;
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
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        public void IntegerIsConvertedToRomanNumerals(int integer, string romanNumerals)
        {
            Assert.True(romanNumerals.Equals(RomanNumerals.FromInteger(integer)));
        }
    }
}