using System;

namespace Learning_Classes_methods
{
    public class Car
    {
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string mode2 { get; set; }
        public string Rate { get; set; }


        public void ApplyBrake()
        {
            Console.WriteLine("Brake applied");
        }
    }
}
