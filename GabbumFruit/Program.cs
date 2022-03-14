using System;

namespace Learning_Classes_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit volvo = new Fruit();
            Fruit.Color = "Red";
            Fruit.Shape = "Rectangle";
            Fruit.Model = "Toyota";
            Fruit.Shell = Hard;
            Fruit.Seed = "Many";

            volvo.ApplyBrake();
            Console.WriteLine("volvo.Colour{0} {1} {2}", volvo.Color, volvo.Model, volvo.Shape);
            Console.ReadLine();
        }
    }
    public class Fruit
    {
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Model { get; set; }
        public String Shell { get; set; }
        public string Seed { get; set; }


        public void ApplyBrake()
        {
            Console.WriteLine("Brake applied");
        }
    }
}