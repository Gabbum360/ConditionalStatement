using System;

namespace TrafficProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LekkiTrafficLight Atp = new LekkiTrafficLight();
            Atp.Color = "Red, Yellow, Green";
            Atp.CycleTime = 24;
            Atp.camera = true;
            Atp.ControlSystem = true;
            Atp.Manual = true;
            
            

            Car Benz = new Car();
            Benz.Color = "White";
            Benz.Manual = true;
            Benz.Model = "4Matic";
            Benz.Year = 2020;
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i); i++;
             //} while (i<5);


            Benz.Stop();
            Console.ReadLine();
            //int speed = Benz.CalculateSpeed(2000, 1);
            //Console.WriteLine("{0}", speed);
            //Console.ReadLine();

            //Console.WriteLine("what is the current state of the traffic Light?");

            //Console.WriteLine("Hello World!");
        }
    }
}
