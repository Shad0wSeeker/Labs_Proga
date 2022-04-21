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
            Bank bank = Bank.GetNewBank("Tinkoff", 1000, 400, 5.5);
            CustomerType cs = CustomerType.Standart;
            CustomerType cs_2 = CustomerType.VIP;
            Customer customer_1 = Customer.GetNewCustomer("Qwert", cs);
            Customer customer_2 = Customer.GetNewCustomer("hjvf", cs_2);
            Assert.Equal("Qwert",customer_1.GetFIO());
            Assert.Equal("Client is STANDART", customer_1.GetType(cs));

            Assert.Equal("Qwert",bank.GetCustomer(customer_1));
            Assert.Equal("QWERTYUI", bank.ChangeFIO(customer_1, "QWERTYUI"));
            Assert.Equal("Client is STANDART", bank.GetTypeOfCustomer(customer_1, cs));
            Assert.Equal("Client is VIP", bank.GetTypeOfCustomer(customer_2, cs_2));
            bank.GetNewConrOfCustomer(customer_1, 5000, 32);
            bank.GetNewConrOfCustomer(customer_2, 1500, 12);

            Assert.Equal(5000,bank.GetSizeOfContr(customer_1));
            Assert.Equal(32,bank.GetBetOfContr(customer_1));
            
            Assert.Equal(0.24,bank.PaymentOfCustomers(customer_2));
            Assert.Equal(2000,(bank.IncreaseSizeOfContr(customer_2, 500)));
        }
    }
}