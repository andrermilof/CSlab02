using System;
using System.Security.Cryptography;

namespace exer2
{
    public class Vehicle
    {
        private int x, y, price, speed, year;

        public Vehicle(int x, int y, int price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        
        public virtual void Show()
        {
            Console.WriteLine($"X:\t{x}\nY:\t{y}\nPrice:\t{price}\nSpeed:\t{speed}\nYear:\t{year}");
        }
    }

    public class Car : Vehicle
    {
        public Car(int x, int y, int price, int speed, int year) 
            : base(x, y, price, speed, year) { }
    }

    public class Plane : Vehicle
    {
        int pass, hight;

        public Plane(int x, int y, int price, int speed, int year, int pass, int hight)
            : base(x, y, price, speed, year)
        {
            this.pass = pass;
            this.hight = hight;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Passengers:\t{pass}\nHight:\t{hight}");
        }
    }

    public class Ship : Vehicle
    {
        private int pass, port;
        
        public Ship(int x, int y, int price, int speed, int year, int pass, int port)
            : base(x, y, price, speed, year)
        {
            this.pass = pass;
            this.port = port;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Passengers:\t{pass}\nPort:\t{port}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(13, 13, 3000, 60, 1950);
            Plane pl = new Plane(15, 15, 5000, 300, 1950, 33, 500);
            Ship sh = new Ship(17, 17, 7000, 50, 1950, 44, 63);

            car.Show();
            Console.WriteLine('\n');
            pl.Show();
            Console.WriteLine('\n');
            sh.Show();
        }
    }
}
