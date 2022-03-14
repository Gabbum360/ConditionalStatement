using System;

namespace GabbumCar 
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck mercedez = new Truck();
            mercedez.Shape = "Rectangle";
            mercedez.Size = "Large";
            mercedez.Color = "Blue";
            mercedez.TireSize = 19515;
            mercedez.Tank = 6000;
            mercedez.Year = 2021;
        
            Console.WriteLine("Please enter cost of truck");
            mercedez.Cost = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("please indicate the year of truck");
            mercedez.Year = Convert.ToInt16(Console.ReadLine());

            decimal speed = mercedez.CalculateSpeed(2000, 2);
            Console.WriteLine("speed is {0}", speed);
            Decimal LifeSpan = mercedez.CalculateLifeSpan(7, 6, 250);
            Console.WriteLine("LifeSpan duration is {0}", LifeSpan);
            decimal Weight = mercedez.CalculateWeight(360, 70);
            Console.WriteLine("Weight of truck is {0}", Weight);
            bool isTruckExpensive = mercedez.IsTruckExpensive(mercedez.Cost);
            if(isTruckExpensive == true)
            {
                Console.WriteLine("Truck is expensive");
            }
            else
            {
                Console.WriteLine("Truck is not expensive");
            }
            int WhatYearWasItProduced = mercedez.WhatYearWasItProduced(mercedez.Year);
            if (WhatYearWasItProduced == 2003)
            {
                Console.WriteLine("Truck is an Old model");
            }
            else
            {
                Console.WriteLine("Truck is the latest model");
            }



            Console.ReadLine();

            //    Car Benz = new Car();
            //Benz.Color = "Red";
            //Benz.Shape = "Rectangle";
            //Benz.Model = "Toyota";
            //Benz.Year = 2020;
            //Benz.mode2 = "Diesel";
            //Benz.Rate= "5stars";

            //Benz.ApplyBrake();
            //Console.WriteLine("Benz.Year{0}, Benz.Mode2 {1}", Benz.Year, Benz.Year);
            //    Console.WriteLine("Benz.Colour{0}, Benz.Mode1{1} {2}", Benz.Color, Benz.Model, Benz.Shape);
            //Console.WriteLine("A Benz Car can be imported as commondity");
            //Console.WriteLine("A Benz Car can be fueld");
            //Console.WriteLine("A Benz Car can is rated 5star");
            //Console.WriteLine("A Benz Car can accelerate");
            //Console.ReadLine();
            
        }
    
    }
}
