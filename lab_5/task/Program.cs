using System;
using System.Collections.Generic;

namespace task
{
    public enum CustomerType 
    {
        VIP,
        Standart
    }    

    public class Bank
    {
        private string name;
        private static Bank bank;
        private Bank_Contribution contribution;
        private Customer customer;
        private CustomerType customerType;

        private Bank(string name_1, int size_1, int amount_1, double bet_1)
        {
            contribution = new Bank_Contribution(size_1, amount_1, bet_1);
            name = name_1;            
        }

        public static Bank GetNewBank(string name = "anything", int size = 0, int amount = 0, double bet = 0)
        {
            if (bank == null)
            {
                return bank = new Bank(name, size, amount, bet);
            }
            else
                return bank;
        }



        
        public string GetCustomer(Customer customer)
        {
            return customer.GetFIO();
        }

        public string GetTypeOfCustomer(Customer customer, CustomerType cs)
        {
            return customer.GetType(cs);
        }

        public string ChangeFIO(Customer customer, string FIO)
        {
            return customer.ChangeFIO(FIO);
        }

        public Bank_Contribution GetNewConrOfCustomer(Customer customer, int size_1, double bet_1)
        {
            return customer.GetNewContribution(size_1, bet_1);
        }

        public int GetSizeOfContr(Customer customer)
        {
            return customer.GetSize();
        }

        public int IncreaseSizeOfContr(Customer customer, int size)
        {
            return customer.IncreaseSize(size);
        }
        public double GetBetOfContr(Customer customer)
        {
            return customer.GetBet();
        }




        public double Payment()
        {
            double result = contribution.GetBet() / 100 * contribution.GetAmount();
            return result;
        }

        public double PaymentOfCustomers(Customer customer)
        {
            double result = customer.GetBet() / 100 * customer.GetCounter();
            return result;
        }
        public void IncreaseSize(int value = 1)
        {
            contribution.IncreaseSize(value);
        }
        public void DecreaseSize(int value = 1)
        {
            contribution.DecreaseSize(value);
        }
        public void IncreaseAmount(int value = 1)
        {
            contribution.IncreaseAmount(value);
        }
        public void DecreaseAmount(int value = 1)
        {
            contribution.DecreaseAmount(value);
        }
        public void IncreaseBet(double value = 1)
        {
            contribution.IncreaseBet(value);
        }
        public void DecreaseBet(double value = 1)
        {
            contribution.DecreaseBet(value);
        }
        public void ChangeName(string NewName)
        {
            name = NewName;
        }
        public string GetName()
        {
            return name;
        }
        public int GetSize()
        {
            return contribution.GetSize();
        }
        public int GetAmount()
        {
            return contribution.GetAmount();
        }
        public double GetBet()
        {
            return contribution.GetBet();
        }
        
       
        public string GetType(CustomerType cs)
        {
            return customer.GetType(cs);
        }

        
    }


    public class Bank_Contribution
    {
        private int size;
        private int amount;
        private double bet;
       

        public Bank_Contribution(int size_1, int amount_1, double bet_1)
        {
            size = size_1;
            if (size != 0)
            {
                amount = amount_1;
            }
            else
                amount = 0;
            bet = bet_1;

        }

        public Bank_Contribution(int size_1, double bet_1)
        {
            size = size_1;
            bet = bet_1;

        }

       
        public int GetSize()
        {
            return size;
        }
        public int GetAmount()
        {
            return amount;
        }
        public double GetBet()
        {
            return bet;
        }

        public void IncreaseSize(int value = 1)
        {
            size += value;
        }
        public void DecreaseSize(int value = 1)
        {
            if (size < value)
            {
                size = 0;
            }
            else
                size -= value;
        }
        public void IncreaseAmount(int value = 1)
        {
            amount += value;
        }
        public void DecreaseAmount(int value = 1)
        {
            if (amount < value)
            {
                amount = 0;
            }
            else
                amount -= value;
        }
        public void IncreaseBet(double value = 1)
        {
            bet += value;
        }
        public void DecreaseBet(double value = 1)
        {
            if (bet < value)
            {
                bet = 0;
            }
            else
                bet -= value;
        }


    }




    public class Customer
    {       
        private static Customer customer;
        private string FIO; 
        private CustomerType customerType;
        private Bank_Contribution contribution;
       

        private int size;      
        private double bet;
        private double bet_n;
        public static int counter;

        public Customer(int size_1, double bet_1)
        {
            size = size_1;            
            bet = bet_1;

        }
        private Customer(string FIO_1, CustomerType cs)
        {
            FIO = FIO_1;
            customerType = cs;
        }

        public static Customer GetNewCustomer(string FIO, CustomerType cs)
        {
            counter += 1;
            return customer = new Customer(FIO, cs);
            
        }

        public int IncreaseSize(int value = 1)
        {
            size += value;
            return size;
        }

        public Bank_Contribution GetNewContribution(int size_1,  double bet_1)
        {
            
            size = size_1;
            bet_n = bet_1;
            return contribution = new Bank_Contribution(size, bet);
            
        }

        public int GetCounter()
        {
            return counter;
        }

        public string GetFIO()
        {
            return FIO;
        }

        public string ChangeFIO(string NewFIO)
        {            
            return NewFIO;
        }
        public int GetSize()
        {
            return size;
        }
        
        public double GetBet()
        {
            return bet + bet_n;
        }

        public string GetType(CustomerType cs)
        {
            //  cs = CustomerType.VIP;
            string ans_1 = "Client is VIP";
            string ans_2 = "Client is STANDART";
         
            if (cs == 0)
            {
                return ans_1;
            }
            else 
            {
                return ans_2;
            }
          
        }

    }

   
    public class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = Bank.GetNewBank("Tinkoff", 1000, 400, 5.5);
            Console.WriteLine(bank.GetName());
            Console.WriteLine(bank.GetSize());
            Console.WriteLine(bank.GetAmount());
            Console.WriteLine(bank.GetBet());
            Console.WriteLine();
            
            
            bank.IncreaseAmount(100);
            Console.WriteLine(bank.GetAmount());
            Console.WriteLine(bank.Payment());
            Console.WriteLine();
            Console.WriteLine();

            //////////////////////////////////////////////////////



            CustomerType cs = CustomerType.Standart;
            Customer customer_1 = Customer.GetNewCustomer("Qwert", cs);
            Customer customer_2 = Customer.GetNewCustomer("hjvf", cs);
            Console.WriteLine(customer_1.GetFIO());
            Console.WriteLine(customer_1.GetType(cs));
            
            Console.WriteLine(bank.GetCustomer(customer_1));
            Console.WriteLine(bank.ChangeFIO(customer_1, "QWERTYUI"));
            Console.WriteLine(bank.GetTypeOfCustomer(customer_1, cs));
            bank.GetNewConrOfCustomer(customer_1, 5000, 32);
            bank.GetNewConrOfCustomer(customer_2, 1500, 12);
           
            Console.WriteLine(bank.GetSizeOfContr(customer_1));
            Console.WriteLine(bank.GetBetOfContr(customer_1));
            customer_1.GetNewContribution(12345, 324);
            Console.WriteLine(bank.GetSizeOfContr(customer_1));
            Console.WriteLine(bank.GetBetOfContr(customer_1));

            Console.WriteLine(bank.PaymentOfCustomers(customer_2));
            Console.WriteLine(customer_1.GetCounter());

           

        }
    }
}