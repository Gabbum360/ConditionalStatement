using System;

namespace FoundationaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // args method that takes 5 parameters, add up the five parameters multiplied by 10 and divide by 1000
            //Program Person = new Program();
            Person John = new Person();


            int Age = John.CalculateAge(2021, 1996);
            Console.WriteLine("John is {0}", Age);


            

            

            //int CostPrice = program.CostPrice(3500, 2500);
            //Console.WriteLine("cost price is {0}", CostPrice);
            //var myNum = program.MyNum(10, 15, 45, 3, 34); ; ;;

            //decimal calculate = program.Calculate(10, 15); ; ; ;

            //string firstName = "ochayi";
            //string secondName = "gabriel";
            //string fullName = program.ConcatenateFullName("ochayi","gabriel");
            //Console.WriteLine(fullName);

            Console.ReadLine();

            
        }
        //string name = $"My full name is: {firstName} {lastName}";
        //Access modifier's
        //Public, internal, protected, private
        public int MyNum(int a, int b, int c, int x, int y)
        {
            var MyNum = (a + b + c + x + y * 10 / 1000);
            return MyNum;

        }

        public decimal Calculate(decimal x, decimal y)
        {
            decimal Calculate = (x + y);
            return Calculate;
        }
        public string ConcatenateFullName(string fname, string sname)
        {
            string fullName = $"{fname} {sname}";
            return fullName;
        }
        public int CostPrice(int costPrice, int sellingPrice)
        {
            var Price = (costPrice / sellingPrice);
            return Price;
        }
        public int CalculateAge(int givenDate, int dateOfBirth)
        {
            Person John = new Person();
            int age = givenDate - dateOfBirth;
            return age;

            int Age = John.CalculateAge(2021, 1996);
            Console.WriteLine("John is {0}", Age);
            Console.WriteLine("John is Dancing");
            
        }
    }
}
