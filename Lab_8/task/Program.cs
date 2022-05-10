using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
   
    interface IPrice
    {
        public int GetPrice();
        public string GetInfo();

        public bool GetIsOnDis();
    }

    class FullPrice : IPrice
    {
        private int _price = 0;
        private bool _disc = false;

        public FullPrice(int pr)
        {
            _price = pr;
        }

        public int GetPrice()
        {
            return _price;
        }

        public string GetInfo()
        {
            return "Ticket does not have a discount  \nPrice:  " + _price.ToString();
        }

        public bool GetIsOnDis()
        {
            return _disc;
        }
    }

    class DiscountPrice : IPrice
    {
        private int _price = 0, _discount = 0;
        private bool _disc = true;

        public DiscountPrice(int pr, int dis)
        {
            _price = pr - pr * dis / 100;
            _discount = dis;
        }

        public int GetPrice()
        {
            return _price;
        }

        public string GetInfo()
        {
            return "Ticket has a discount\nPrice:  " + _price.ToString() + "   " + " Discount:    " + _discount.ToString() + "%";
        }

        public bool GetIsOnDis()
        {
            return _disc;
        }

    }
    public class Ticket
    {
        private IPrice _price;
        private string _destination = "";
        public Ticket(string dest, int pr)
        {
            _destination = dest;
            _price = new FullPrice(pr);
        }
        public Ticket(string dest, int pr, int dis)
        {
            _destination = dest;
            _price = new DiscountPrice(pr, dis);
        }

        public int GetPrice()
        {
            return _price.GetPrice();
        }

        public string GetInfo()
        {
            return "Destination: " + _destination + "\n" +
            _price.GetInfo();
        }

        public bool GetIsOnDis()
        {
            return _price.GetIsOnDis();
        }

    }
    public class Aeroport
    {
        private List<Ticket> tickets = new List<Ticket>(0);
         
        public void FullInfo()
        {
            int whole_cost = 0, i = 1;
            string info = "";
            foreach (Ticket ticket in tickets)
            {
                whole_cost += ticket.GetPrice();
                info += "№" + i.ToString() + "\n" + ticket.GetInfo() + "\n";
                i++;
            }

            Console.WriteLine(info + "\nTotal Cost: " + whole_cost.ToString());
            Console.WriteLine(HighestPrice());
            Console.WriteLine(" \n");
        }

        public void AddTarrif(Ticket tick)
        {
            tickets.Add(tick);
        }

        public string HighestPrice()
        {
            return "Highest price: " + (tickets.Max(ticket => ticket.GetPrice())).ToString();
        }

    }


    class Program
    {

        public static void AddMain(ref Aeroport aeroport)
        {
            string answer = "qq", destination = "ww";
            int pr = 0;
            Console.WriteLine("Place of destination: ");
            destination = Console.ReadLine();
            Console.WriteLine("Price (integer): ");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out pr)) ;
            } while (pr < 1);
            Console.WriteLine("Would you like to make a discount?\t\t");

            do
            {
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "no");

            switch (answer)
            {
                case "yes":
                    {
                        int dis;
                        Console.WriteLine("Discount, %:  ");
                        do
                        {
                            while (!int.TryParse(Console.ReadLine(), out dis)) ;
                        } while (dis < 1 || dis > 100);
                        Ticket first = new Ticket(destination, pr, dis);
                        aeroport.AddTarrif(first);
                        break;
                    }
                case "no":
                    {
                        Ticket first = new Ticket(destination, pr);
                        aeroport.AddTarrif(first);
                        break;
                    }
            }
        }

        static void Main(string[] args)
        {

            Aeroport aeroport = new Aeroport();

           
            AddMain(ref aeroport);

            bool rep = true;

            while (rep)
            {

                Console.WriteLine("Choose action:\n1.  Get info about tarrifs\n2.  Add new ticket\n3.  Exit   ");


                int action = 0;
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out action)) ;
                } while (action < 1 || action > 3);

                switch (action)
                {
                    case 1:
                        {                            
                            aeroport.FullInfo();
                            Console.WriteLine("\n\n");
                            break;
                        }
                    case 2:
                        {                            
                            AddMain(ref aeroport);
                            break;
                        }
                    case 3:
                        {
                            rep = false;
                            break;
                        }
                }

            }


        }
    }
}