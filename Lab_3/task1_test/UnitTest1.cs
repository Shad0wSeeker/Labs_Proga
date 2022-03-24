using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static task1.Class1;

namespace task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            long expected = 0;
            long result = func(33);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            long expected = 22;
            long result = func(44);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            long expected = -281;
            long result = func(-562);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            long expected = 0;
            long result = func(-365);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test5()
        {
            long expected = 0;
            long result = func(0);
            Assert.Equal(expected, result);
        }
    }
}