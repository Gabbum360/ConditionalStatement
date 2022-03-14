using System;

namespace IndependentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform Noun = new Platform();
            //Noun.Author = "Gabbum";
            //Noun.Model = "Hybrid";
            Platform App = new Platform();


            //Noun.WhatPlatform();
            //string name = "Gabbum";
            //Console.WriteLine("Hello " + name);
            Noun.Install();


            Console.ReadLine();

        }
        

    }
}
