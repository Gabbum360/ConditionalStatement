using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace TrafficProject
{
    class Car
    {
        //public int Sqrt { get; set; }

        //public int CalculateSquareroot(int x, int y);
        //int Squareroot = (x / y)
        //    return Squareroot;

        
       
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Manual { get; set; }



        public int CalculateSpeed(int distance, int time)
        {
            int speed = distance / time;
            return speed;
        }
        public void Speed()
        {
            Console.WriteLine("A Car can move in speed");
        }
        public void Accelerate()
        {
            Console.WriteLine("Car should start moving now");
            Console.ReadLine();
            Stop();
        }
        public void Accelerate2()
        {

            Console.WriteLine("please wait while Pedestrians cross and intersection Crossing take place");
            Console.ReadLine();
            LekkiTrafficLight ats = new LekkiTrafficLight();
            Decimal TimePass = ats.CalculatePedestrianTimePass(15, 10);
            Console.WriteLine("TimePass for pedestrians is {0}, please endeavor to be patient while it take process", TimePass);
            Console.ReadLine();
            StopCar();
        }
        public void ApplyBrake()
        {
            Console.WriteLine("please apply your brake to the maximum on or before you get to the designated StopPoint");
        }
        public void Move()
        {
            LekkiTrafficLight atp = new LekkiTrafficLight();
            atp = new LekkiTrafficLight();
            {
                atp.CurrentState = "Green";
                Console.WriteLine("Car may move now");
                var MoveTime = atp.CalculateMoveTime(80, 600, 160);
                Console.WriteLine("you have {0} minutes to Drive pass the TrafficLight before it Changes", MoveTime);
                Console.ReadLine();

            }

        }
        public void StopCar()
        {
            LekkiTrafficLight ats = new LekkiTrafficLight();
            ats.CurrentState = "Red";
            Console.WriteLine("Car stopped");
            Decimal TimePass = ats.CalculatePedestrianTimePass(15, 10);
            Console.WriteLine("TimePass for pedestrians is {0}, please endeavor to be patient while it take process", TimePass);
            Console.ReadLine();
            Console.WriteLine("Change the TrafficLight state");
            string CurrentState = Console.ReadLine();
            Console.WriteLine("{0}", CurrentState);
            if (CurrentState == "Orange")
            {
                ApplyBrake();
            }
            else if (CurrentState == "Red")
            {
                Accelerate2();
            }
            else
            {
                MoveCar();
            }
        }
        public void Stop()
        {

            LekkiTrafficLight atp = new LekkiTrafficLight();
            atp.CurrentState = "Red";
            Console.WriteLine("Car stopped");
            Decimal TimePass = atp.CalculatePedestrianTimePass(37, 30);
            Console.WriteLine("TimePass for pedestrians is {0} minutes, please endeavor to be patient while it take process", TimePass);
            Console.WriteLine("wait while the TrafficLight Conductor changes the traffisLight status");
            if (atp.CurrentState == "Red")
            {
                StopCar();
            }
            else if (atp.CurrentState == "Orange")
            {
                PedestrianCross();
            }
            else
            {
                MoveCar();
            }
        }
        public void PedestrianCross()
        {
            LekkiTrafficLight atp = new LekkiTrafficLight();
            Console.WriteLine("whats the time duration given for pedestrian TimePass?");
            Decimal TimePass = atp.CalculatePedestrianTimePass(37, 30);
            Console.WriteLine("TimePass is {0}", TimePass);








            //public String ApplyBrake()
            //{
            //    Console.WriteLine("A car can Apply Brake");
            //}



        }
        public void MoveCar()
        {
            AjahTrafficLight ats = new AjahTrafficLight();
            {
                ats.CurrentState2 = "Green";
                Console.WriteLine("Car may move now");
                var MoveTime = ats.CalculateMoveTime(20, 70, 10);
                Console.WriteLine("you have {0} minutes to Drive pass the TrafficLight before it Changes", MoveTime);
                Console.ReadLine();

            }

        }

    }
}
