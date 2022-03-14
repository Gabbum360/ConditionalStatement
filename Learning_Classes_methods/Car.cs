using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Classes_methods
{
    public class Fruit
    {
        public string Color { get; set; }
        public string Taste { get; set; }
        public string Seed { get; set; }
        public int Year { get; set; }


        public void SeedPlanted()
        {
            Console.WriteLine("SeedPlanted");
        }
    }
}
