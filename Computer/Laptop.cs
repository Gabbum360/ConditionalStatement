using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class Laptop
    {
        public string Shape { get; set; }
        public string Color { get; set; }
        public decimal Cost { get; set; }
        public string Form { get; set; }
        public int Storage { get; set; }
        public int BatteryLife { get; set; }



        public string DisplayNameOfLaptop()
        {
            string name = "HP";
            return name;
        }


        public bool IsLaptopExpensive(Decimal Cost)
        {
            if (Cost > 400000)
                return true;
            else
                return false;
        }
        public void isLaptopStorageSmall(int Storage)
        {
            Console.WriteLine("IsLaptopStorageSmall");
            if (Storage > 500)
            {
                Console.WriteLine("Laptop space is very good and spacious");
            }
            else
            {
                Console.WriteLine("The Laptop Storage is tpoo Small for your System");
            }

            //if (Storage is < 500)
            //    return 500;
            //else
            //    return 1000;
        }
        public int laptpCostPrice(int costPrice, int sellingPrice)
        {
            var Price = (costPrice / sellingPrice);
            return Price;
        }
        public int CostPrice(int costPrice, int sellingPrice)
        {
            var Price = (costPrice / sellingPrice);
            return Price;
        }


    }
    



}
