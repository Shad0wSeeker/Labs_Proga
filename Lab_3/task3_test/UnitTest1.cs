using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static task3.DateService;


namespace task3_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 200;
            int result = GetDaysSpan(10, 10, 2022, 24,03,2022);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int expected = 2;
            int result = GetDaysSpan(26,03,2022, 24, 03, 2022);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int expected = 201;
            int result = GetDaysSpan(11, 10, 2022, 24, 03, 2022);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            string expected = "четверг";
            string date = "24.03.2022";
            string result = GetDay(date);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test5()
        {
            string expected = "суббота";
            string date = "26.03.2022";
            string result = GetDay(date);
            Assert.Equal(expected, result);
        }

        
    }
}