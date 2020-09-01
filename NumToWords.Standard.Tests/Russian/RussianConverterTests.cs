using NumToWords.Standard.Russian;
using Xunit;

namespace NumToWords.Standard.Tests.Russian
{
    public sealed partial class RussianConverterTests
    {
        [Fact]
        public void RubleKopekTest()
        {
            var number = 123.45M;
            var expected = "сто двадцать три рубля сорок пять копеек";

            var actual = RussianConverter.FormatCurrency(number);

            Assert.Equal(expected, actual);
        }


        #region Helpers

        private void MasculineNumberTestHelper(long number, string expected)
        {
            var actual = RussianConverter.Format(number);
            Assert.Equal(expected, actual);
        }

        private void RubleNumberTestHelper(long number, string expected)
        {
            var actual = RussianConverter.Format(number, UnitOfMeasure.Ruble);
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}

