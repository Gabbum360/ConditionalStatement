using System;
using System.Linq;
using System.Collections;

namespace Collection
{
    class Arrays
    {
        public void CallStringItem()
        {
                string[] heart = new string[] { "funmi", "Grace", "Titi", };
                //heart[0] = "funmi";
                //heart[1] = "Mercy";
                //heart[2] = "Titi";
                //for (int i = 0; i < heart.Length; i++)
                //{
                //    Console.WriteLine("myHeart beats for = " + heart[0]);
                //}
                Console.WriteLine(heart.Length);
                Console.WriteLine(heart[2]);
        }
        public void foodList()
        {
            string[] food = { "Rice", "Beans", "Yam", "Eba", "Semovita", "Maize", "Plantain" };
            for (int i = 7; i <= food.Length; i++)
                Console.WriteLine("my favourite food is {1} and {6}", food);
            Console.WriteLine("the length of this given value is ", food.Length);
            Console.WriteLine("these are the list of food we have listed as follows ", food);
        }
        public void dietSort()
        {
            int[] food = new int[5] { 3, 4, 10, 20, 7 };
            food[0] = 1;
            food[1] = 4;
            food[2] = 10;
            food[3] = 3;
            food[4] = 20;
            int[] diet = food;

           // Console.WriteLine(diet);
            Array.Sort(food);
            //foreach (int item in food)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
