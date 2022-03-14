using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficProject
{
    class Car2
    {
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
        public void Accelerate2()
        {
            Console.WriteLine("please wait while Pedestrians cross and intersection Crossing take place");
            Console.ReadLine();
            StopCar();
        }
        public void ApplyBrake()
        {
            Console.WriteLine("please apply your brake to the maximum on or before you get to the designated StopPoint");
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
        public void StopCar()
        {
            AjahTrafficLight ats = new AjahTrafficLight();
            ats.CurrentState2 = "Red";
            Console.WriteLine("Car stopped");
            Decimal TimePass = ats.CalculatePedestrianTimePass(15, 10);
            Console.WriteLine("TimePass for pedestrians is {0}, please endeavor to be patient while it take process", TimePass);
            Console.ReadLine();
            Console.WriteLine("Change the TrafficLight state");
            string CurrentState = Console.ReadLine();
            Console.WriteLine("{0}", CurrentState);
            if (CurrentState == "Green")
            {
                MoveCar();
            }
            else if (CurrentState == "Red")
            {
                ApplyBrake();
            }
            else
            {
                Accelerate2();
            }
        }
        public void Move()
        {
            AjahTrafficLight atp = new AjahTrafficLight();
            {
                atp.CurrentState2 = "Green";
                Console.WriteLine("Car may move now");
                var MoveTime = atp.CalculateMoveTime(80, 600, 160);
                Console.WriteLine("you have {0} minutes to Drive pass the TrafficLight before it Changes", MoveTime);
                Console.ReadLine();

            }

        }
        public void PedestrianCross()
        {
            AjahTrafficLight ats = new AjahTrafficLight();
            Console.WriteLine("whats the time duration given for pedestrian TimePass?");
            Decimal TimePass = ats.CalculatePedestrianTimePass(15, 10);
            Console.WriteLine("TimePass is {0}", TimePass);
        }
    }
}
