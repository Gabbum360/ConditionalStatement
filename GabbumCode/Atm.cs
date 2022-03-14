using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabbumCode
{
    public class Atm
    {
        int pin = 0;
        int mypin = 1235;

        int function = 0;
        int myfunction = 1;
        int YES = 1;
        int NO = 2;
        Decimal accountBalance = 3000;
        Decimal staticAccountBalance = 1000;

        int TopupAirtime = 1;
        int Transfer = 2;
        int OtherTransaction = 3;

        Decimal amountToTransact = 0;
        Decimal amountToTopup = 0;
        Decimal phonenumber = 0;
        Decimal myphonenumber = 09092803925;

        int ETISALAT = 1;
        int MTN = 2;
        int GLO = 3;
        int AIRTEL = 4;
        int ZenithBank = 1;
        int gtBank = 2;
        int ubaBank = 3;

        public void WithdrawFromAtm()
        {
            Console.WriteLine("please insert your Card");
            Console.ReadLine();
            Console.WriteLine("Hello Mr Gabriel");
            Console.WriteLine("please input your Pin");
            long inputedpin = Convert.ToInt64(Console.ReadLine());
            if (inputedpin == mypin)
            {
                Console.WriteLine("please select a function: press (1) for Topup Airtime, (2) for Transfer or (3) for Other Transaction");
                long answer = Convert.ToInt64(Console.ReadLine());
                if (answer == TopupAirtime)
                {
                    TopUp();
                }
                else if (2 == Transfer)
                {
                    Transact();
                }
                else
                {
                    Print();
                }
            }
            else
            {
                Worst();
            }
        }

        public void TopUp()
        {
            Console.WriteLine("please input the phone number you want to Topup");
            Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("select network: press (1) for ETISALAT, (2) for MTN, (3) for GLO or (4) for AIRTEL");
           long net = Convert.ToInt64(Console.ReadLine());
            if (net == ETISALAT)
            {
                Console.WriteLine("select amount");
                Console.ReadLine();
                if (amountToTopup > accountBalance)
                {
                    Console.WriteLine("insufficient accountBalance");
                }
                else if (amountToTopup < accountBalance)
                {
                    Console.WriteLine("please wait while your request is being processed");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("please wait while your request is being processed");
                    Console.ReadLine();
                }
                Decimal newAccountBalance = accountBalance - amountToTopup; Console.ReadLine();

                Console.WriteLine(" your newaccountBalance is {0}, after amountToTopup", newAccountBalance, amountToTopup);

                Console.WriteLine("do you want to perform another transaction? press (1) to continue, (2) to cancel");
                Console.ReadLine();
                if (1 == YES)
                {
                    Console.WriteLine("please insert your card");
                }
                else
                {
                    Console.WriteLine("Thank you for your patronage Mr Gabriel");
                }
            }
            else
            {
                Console.WriteLine("invalid network provider");
                Console.ReadLine();
            }


        }
        public void Transact()
        {
            Console.WriteLine("input beneficiary axxountNumber");
            long number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("select the beneficiary bank, [1] for GTB, [2] for ZENITH, [3] for UBA");
           long bNumber = Convert.ToInt64(Console.ReadLine());
            if (bNumber == ubaBank)
            {
                Console.WriteLine("input the amountToTransfer");
                Decimal sum = Convert.ToDecimal(Console.ReadLine());
                if (amountToTransact > accountBalance)
                {
                    Console.WriteLine("insufficient accountBalance");
                }
                else
                {
                    Console.WriteLine("please wait while your request is being processed");
                    Console.WriteLine("transaction completed successfully");
                    Decimal newaccountBalance = accountBalance - amountToTransact;
                    
                    Console.WriteLine(" your  newaccountBalance is {0}, after amountToTransact {1}", newaccountBalance, amountToTransact);



                    Console.WriteLine("do you want to perform another transaction? press (1) to continue, (2) to cancel");
                    long select = Convert.ToInt64(Console.ReadLine());
                    if (select == YES)
                    {
                        Console.WriteLine("please insert your card");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Thank you for your patronage Mr Gabriel");
                        Console.WriteLine("[bNumber + sum + select]Console.ReadLine()");
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        public void Print()
        {
            Console.WriteLine("error! please select correctly");
            Console.WriteLine("please select a function: press (1) for Topup Airtime, (2) for Transfer or (3) for Other Transaction"); ;
            long bNumber1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("oga select well na");
            Decimal sum1 = Convert.ToDecimal(Console.ReadLine());
            if (amountToTopup > accountBalance)
            {
                Console.WriteLine("insufficient accountBalance");
            }
            else
            {
                Console.WriteLine("please wait while your request is being processed");
                Console.ReadLine();
                Console.WriteLine("transaction completed successfully");
                Console.ReadLine();
            }
        }
        public void Worst()
        {
            Console.WriteLine("incorrect password, please input your Pin");
            long inputedpin2 = Convert.ToInt64(Console.ReadLine());
            if (inputedpin2 == mypin)
            {
                Console.WriteLine("please select a function: press (1) for Topup Airtime, (2) for Transfer or (3) for Other Transaction");
            }
            else
            {
                Console.WriteLine("please take your card");
            }
            Console.ReadLine();
        }

    }
}
