using MirrorKata.App;

namespace MirrorKata.Tests
{
    public class MirrorTests
    {
        [Theory]
        [InlineData("05:25", "06:35")]
        [InlineData("01:50", "10:10")]
        [InlineData("11:58", "12:02")]
        [InlineData("12:01", "11:59")]
        public void GetMirroredTimeShouldReturnMirroredTime(string time, string expectedMirror)
        {
            Assert.Equal(expectedMirror, MirrorService.GetMirroredTime(time));
        }
    }
}