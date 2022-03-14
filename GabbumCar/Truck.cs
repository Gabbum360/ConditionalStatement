using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabbumCar
{
    public class Truck
    {
        public bool HasTire { get; set; }
        public int TireSize { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Tank { get; set; }
        public string Country { get; set; }
        public string Shape { get; set; }
        public int Year { get; set; }
        public decimal Cost { get; set; }

        

        public decimal CalculateSpeed(int distance, int time)
        {
            var speed = (distance / time);

            return speed;
        }
        public Decimal CalculateWeight(decimal Mass, decimal Gravity)
        {
            decimal Weight = Mass * Gravity;
            return Weight;
        }
      public decimal CalculateLifeSpan(decimal Qx, decimal Mx, decimal Bx)
        {
            var LifeSpan= Mx / (Bx + (Mx / 2));
            return LifeSpan; 
        }
        public bool Time(bool D, bool D2)
        {
            Console.WriteLine("Yes");
            return true;
        }
        
        public bool IsTruckExpensive(decimal cost)
        {
            if(cost > 20000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int WhatYearWasItProduced(int year)
        {
            if (year < 2021)
            {
                return 2003;
            }
            else
            {
                return 2021;
            }
        }

       

        
    }
    
    
}

