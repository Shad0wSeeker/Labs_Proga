using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static task1.Division;


namespace task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            bool result = func(33);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            bool expected = true;
            bool result = func(99);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            bool expected = false;
            bool result = func(13);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            bool expected = false;
            bool result = func(76);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test5()
        {
            bool expected = true;
            bool result = func(33);
            Assert.Equal(expected, result);
        }
    }
}