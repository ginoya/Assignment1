using Assignment1;


namespace Assigment1Test
{
    public class UnitTest1
    {
        [Fact]
        public void LengthIs4()
        {
            Assert.Equal(3, LengthHelper.findLength("123"));
        }

        [Fact]
        public void LengthIs0()
        {
            Assert.Equal(12, LengthHelper.findLength("123456789010"));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]

        public void LengthTheoryToReturn0(string inputStr)
        {
            Assert.Equal(0,LengthHelper.findLength(inputStr));
        }
    }
}