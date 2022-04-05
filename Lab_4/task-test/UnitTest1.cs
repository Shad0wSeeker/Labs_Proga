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
            Bank bank = Bank.GetNewBank("Tinkoff", 1000, 500, 5.5);
            Assert.Equal("Tinkoff", bank.GetName());
            Assert.Equal(1000, bank.GetSize());
            Assert.Equal(500, bank.GetAmount());
            Assert.Equal(5.5, bank.GetBet());

            bank.ChangeName("FFFB");
            Assert.Equal("FFFB", bank.GetName());
            
            bank.IncreaseSize(320);
            Assert.Equal(1320, bank.GetSize());
            
            bank.IncreaseAmount(100);
            Assert.Equal(600, bank.GetAmount());
            
            bank.DecreaseAmount(200);
            Assert.Equal(400, bank.GetAmount());
            
            bank.DecreaseBet(1.5);
            Assert.Equal(4, bank.GetBet());
            
            bank.IncreaseBet(5);
            Assert.Equal(9, bank.GetBet());
            Assert.Equal(36, bank.Payment());
        }
    }
}