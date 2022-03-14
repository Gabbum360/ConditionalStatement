using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentProject
{
    class Platform
    {
       public bool Manual { get; set; }
        public int Date { get; set; }
        public string Author { get; set; } = "Gabbum";
        public string Model { get; set; } = "Hybrid";
        public int Size { get; set; }
        public bool Cost { get; set; }
        public string app { get; set; }
        public string CurrentHomepage { get; set; }

        //public void WhatPlatform()
        //{
        //    Platform Tv = new Platform();
        //    Console.WriteLine("what year was this made?");
        //    var  Date = Convert.ToDecimal(Console.ReadLine());
        //    if (Date == 1996)
        //    {
        //        Console.WriteLine("current model established");
        //    }
        //    else if (Date < 1990)
        //    {
        //        Console.WriteLine("old model");
        //    }
        //    else
        //    {
        //        Console.WriteLine("error");
        //    }
        //}
        public bool IsTvEspensive(decimal cost)
        {
            if (cost > 30000)
                return true;
            else
                return false;
        }
        public void Install()
        {

            Platform App = new Platform();
            {
                Console.WriteLine("do you want to continue download?");
            }
            
        }
        public void HomePage()
        {
            string app1 = "Message";
            Platform App = new Platform();
            {
                Console.WriteLine("you have some unread messages");
            }
        }
        public void myNetwork()
        {

        }
    }
}
