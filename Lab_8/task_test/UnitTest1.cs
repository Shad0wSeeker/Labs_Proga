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
            List<Ticket> l = new List<Ticket>(0);
            l.Add(new Ticket("a", 12, 1));
            l.Add(new Ticket("b", 45));

            Assert.True(l[0].GetIsOnDis());
            Assert.False(l[1].GetIsOnDis());


            Aeroport a = new Aeroport();
            a.AddTarrif(new Ticket("Moscow", 2000, 10));//1350
            a.AddTarrif(new Ticket("Minsk", 700));

            string sp = a.HighestPrice().Substring(a.HighestPrice().Length - 4, 4);

            Assert.Equal("Highest price: 1800", a.HighestPrice());
            
        }
    }
}