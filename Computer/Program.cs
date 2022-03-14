using System;

namespace Computer
{
    class laptop
    {
        static void Main(string[] args)
        {
            Laptop Hp = new Laptop();
            int CostPrice = Hp.CostPrice(3500, 2500);
            Console.WriteLine("cost price is {0}", CostPrice);
            //Hp.Color = "Black";
            //Hp.Cost = 400000;
            //Hp.Shape = "Rectangle";
            //Hp.Storage = 500;
            //Hp.Battery = 4500;


            
            Console.WriteLine("what is your laptop capacity?");
         
            Hp.isLaptopStorageSmall(Hp.Storage);

            
            bool IsLaptopExpensive = Hp.IsLaptopExpensive(Hp.Cost);
            Console.WriteLine("islaptopExpensive");
            if (IsLaptopExpensive == true)
            {
                Console.WriteLine("Laptop is very expensive");
            }
            else
            {
                Console.WriteLine("its affordable");
            }
            Console.ReadLine();
        
        }
        public int CostPrice(int costPrice, int sellingPrice)
        {
            var Price = (costPrice / sellingPrice);
            return Price;
        }
    }

}
