using System;
using System.Collections.Generic;


namespace task
{
    abstract public class Auto
    {
        private int max_speed = 10;

        public Auto()
        {
            Console.WriteLine("Base class constructor");
            // funk_for_nothing();

        }
               

        abstract public string funk_1();
        public virtual string funk2()
        {
            return "This is a function of abstract class Auto";
        }

        public virtual int speed()
        {
            return max_speed * 5;
        }

        public static void funk_for_nothing()
        {
            Console.WriteLine("not overrided functoin back from BASE CLASS");
        }

        public void NewFunk()
        {
            Console.WriteLine("BASE function to be hiden");
        }

        public virtual int SetSpeed(int sp)
        {
           return max_speed = sp;
        }

        ~Auto()
        {
            Console.WriteLine("Base class destructor");
        }              

    }


    public class Car : Auto
    {
        private static int max_speed = 90;
        public override string funk_1()
        {
            return "redefined function of base class Auto";
        }
        public Car()
        {
            // max_speed = 50;

            Console.WriteLine("CAR constructor");
            funk_for_nothing();
        }
        ~Car()
        {
            Console.WriteLine("CAR destruktor");
        }
        public override string funk2()
        {
            return "overrided function of class Car";
        }

        public override int speed()
        {
            return max_speed;
        }

        public override int SetSpeed(int sp)
        {
           return max_speed = sp;
        }

        public new void NewFunk()
        {
            Console.WriteLine("car function hided by using \"new\" key word");
        }
    }



    public class SportCar : Car
    {
        private static int max_speed = 250;
        public override string funk_1()
        {
            return "This is class sportcar";
        }
        public SportCar()
        {
            //max_speed = 200;
            Console.WriteLine("SPORTCAR constructor");
            funk_for_nothing();
        }
        ~SportCar()
        {
            Console.WriteLine("SPORTCAR destruktor");
        }
        public override string funk2()
        {
            return "overrided function of sportcar";
        }

        public override int speed()
        {
            return max_speed;
        }

        public override int SetSpeed(int sp)
        {
            return max_speed = sp;
        }

        public new void NewFunk()
        {
            Console.WriteLine("SPORTCAR hided function, even from CAR parent class");
        }
    }

    sealed public class Truck : Auto
    {
        private static int max_speed = 60;
        public override string funk_1()
        {
            return "This is an object of truck class";
        }
        public Truck()
        {
            //max_speed = 60;

            Console.WriteLine("Truck constructor");
            funk_for_nothing();
        }
        ~Truck()
        {
            Console.WriteLine("Truck destruktor");
        }
        public override string funk2()
        {
            return "overrided function of truck";
        }

        public override int speed()
        {
            return max_speed;
        }

        public override int SetSpeed(int sp)
        {
            return max_speed = sp;
        }

        public new void NewFunk()
        {
            Console.WriteLine("Truck hided funtion by using \"new\" but calling \"base\".funk()");
            base.NewFunk();
        }

    }



    class Program
    {
        static void Main(string[] args)
        {        
                            
            Console.WriteLine("Creating object of truck:\n");
            Truck truck = new Truck();
            Console.WriteLine(truck.funk_1());
            truck.funk2();
            truck.NewFunk();
            Console.WriteLine("Max speed = " + truck.speed().ToString());
            Console.WriteLine("\n\n");


            Console.WriteLine("Creating object of car:\n");
            Car car = new Car();
            Console.WriteLine(car.funk_1());
            car.funk2();
            car.NewFunk();
            Console.WriteLine("Max speed = " + car.speed().ToString());
            Console.WriteLine("\n\n");



            Console.WriteLine("Creating object of sportcar:\n");
            SportCar sportcar = new SportCar();
            Console.WriteLine(sportcar.funk_1());
            sportcar.funk2();
            sportcar.NewFunk();
            Console.WriteLine("Max speed = " + sportcar.speed().ToString());
            Console.Write("changed value of speed is ");
            sportcar.SetSpeed(11);
            Console.WriteLine(sportcar.speed().ToString());
            Console.WriteLine("\n\n");




        }
    }

}