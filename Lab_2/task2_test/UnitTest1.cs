using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static task2.Program;

namespace task2_test
{
    public class UnitTest1
    {
     
        [Fact]
        public void Test1()
        {
            string expected = "Да";
            string result = func(17, 26);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            string expected = "Да";
            string result = func(19,-26);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string expected = "Да";
            string result = func(0,0);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test4()
        {
            string expected = "Нет";
            string result = func(-13, 12);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test5()
        {
            string expected = "Нет";
            string result = func(15,1);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test6()
        {
            string expected = "Нет";
            string result = func(-10, -15);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test7()
        {
            string expected = "Нет";
            string result = func(15, -13);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test8()
        {
            string expected = "На границе";
            string result = func(15, 0);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test9()
        {
            string expected = "На границе";
            string result = func(0,25);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test10()
        {
            string expected = "На границе";
            string result = func(-25,0);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test11()
        {
            string expected = "На границе";
            string result = func(0, 25);
            Assert.Equal(expected, result);
        }


    }
}