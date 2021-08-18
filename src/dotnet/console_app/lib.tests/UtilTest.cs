using System;
using Xunit;
using lib;

namespace lib.tests
{
    public class UtilTest
    {
        [Fact]
        public void GetTimeString_Returns23Characters()
        {
            var value = Util.GetTimeString();
            Assert.Equal(23, value.Length);
        }
    }
}
