using Assignment1;


namespace Assigment1Test
{
    public class UnitTest1
    {
        [Fact]
        public void LengthIs4()
        {
            Assert.Equal(4, LengthHelper.findLength("sdga"));
        }

        [Fact]
        public void LengthIs0()
        {
            Assert.Equal(0, LengthHelper.findLength(""));
        }

        [Theory]
        [InlineData("1123")]
        [InlineData("asdf")]
        [InlineData(null)]

        public void LengthTheory(string inputStr)
        {
            Assert.Equal(4,LengthHelper.findLength(inputStr));
        }
    }
}