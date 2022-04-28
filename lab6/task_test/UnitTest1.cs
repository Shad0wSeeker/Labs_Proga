using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using task;

namespace task_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Truck truck = new Truck();
            Assert.Equal("This is an object of truck class", truck.funk_1());
            Assert.Equal("overrided function of truck", truck.funk2());
            Assert.Equal(33, truck.SetSpeed(33));

            Car car = new Car();
            Assert.Equal("redefined function of base class Auto", car.funk_1());
            Assert.Equal("overrided function of class Car", car.funk2());
            Assert.Equal(99, car.SetSpeed(99));

            SportCar sportcar = new SportCar();
            Assert.Equal("This is class sportcar", sportcar.funk_1());
            Assert.Equal("overrided function of sportcar", sportcar.funk2());
            Assert.Equal(299, car.SetSpeed(299));


        }
    }
}