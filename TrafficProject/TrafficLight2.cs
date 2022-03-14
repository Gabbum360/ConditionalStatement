using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficProject
{
    class AjahTrafficLight
    {
        public string Color { get; set; }
        public int CycleTime { get; set; }
        public string Shape { get; set; }
        public int SignalTime { get; set; }
        public bool camera { get; set; }
        public bool ControlSystem { get; set; }
        public bool Manual { get; set; }
        public string CurrentState2 { get; set; } = "Green";
        public int PedestrianTimePass { get; set; } = 30;
        public int MoveTime { get; set; } = 1;


        public decimal CalculateMoveTime(decimal speed, decimal Width, decimal AverageDistance)
        {
            decimal MoveTime = (speed * Width / AverageDistance);
            return MoveTime;
        }
        public int CalculatePedestrianTimePass(int Speed, int Distance)
        {
            var TimePass = (Speed / Distance);
            return TimePass;
        }
        public void ChangeTrafficLightState(string currentState)
        {
            this.CurrentState2 = currentState;
        }
    }
}
