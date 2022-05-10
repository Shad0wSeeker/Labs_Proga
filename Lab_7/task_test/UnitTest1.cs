using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using task;
using System.Collections.Generic;

namespace task_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<Quadratic_equation> eqs = new List<Quadratic_equation>(0);

            
            eqs.Add(new Quadratic_equation(17, 0, 8));
            eqs.Add(new Quadratic_equation(43,65,1));
            eqs.Add(new Quadratic_equation(35, 11, 8));
            eqs.Add(new Quadratic_equation(0, 16, 8));

            Assert.True(eqs[0] != eqs[1]);
            eqs[2] += eqs[3];
            Assert.False(eqs[2] != new Quadratic_equation(35, 27, 16));
            eqs[0]++;
            Assert.True(eqs[0] == new Quadratic_equation(17, 0, 9));

            Assert.Equal("Equation: 0+ 16x + 8\nroot: -0,5", eqs[3].Solution());

        }
    }
}