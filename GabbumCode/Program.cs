using System;

namespace GabbumCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Atm atmmachine = new Atm();
            atmmachine.WithdrawFromAtm();

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


            Console.WriteLine("please insert your Card");
            Console.ReadLine();
            Console.WriteLine("Hello Mr Gabriel");
            Console.WriteLine("please input your Pin");
            int inputedpin = Convert.ToInt32(Console.ReadLine());
            if (inputedpin == mypin)
            {
                Console.WriteLine("please select a function: press (1) for Topup Airtime, (2) for Transfer or (3) for Other Transaction");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == TopupAirtime)
                {
                    Console.WriteLine("please input the phone number you want to Topup");
                    Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("select network: press (1) for ETISALAT, (2) for MTN, (3) for GLO or (4) for AIRTEL");
                    int net = Convert.ToInt32(Console.ReadLine());
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

                        Console.WriteLine(" your newaccountBalance is {0}, after Transaction {1}");

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
                else if (2 == Transfer)
                {
                    Console.WriteLine("input beneficiary axxountNumber");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("select the beneficiary bank, [1] for GTB, [2] for ZENITH, [3] for UBA");
                    int bNumber = Convert.ToInt32(Console.ReadLine());
                    if (bNumber == ubaBank)
                    {
                        Console.WriteLine("input the amountToTransfer");
                        Decimal sum = Convert.ToDecimal(Console.ReadLine());
                        if (amountToTopup > accountBalance)
                        {
                            Console.WriteLine("insufficient accountBalance");
                        }
                        else
                        {
                            Console.WriteLine("please wait while your request is being processed");
                            Console.ReadLine();
                            Console.WriteLine("transaction completed successfully");
                            Console.WriteLine("do you want to perform another transaction? press (1) to continue, (2) to cancel");
                            int select = Convert.ToInt32(Console.ReadLine());
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
                else
                {
                    Console.WriteLine("error! please select correctly");
                    Console.WriteLine("please select a function: press (1) for Topup Airtime, (2) for Transfer or (3) for Other Transaction"); ;
                    int bNumber1 = Convert.ToInt32(Console.ReadLine());
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
            }
            else
            {
                Console.WriteLine("incorrect password, please input your Pin");
                int inputedpin2 = Convert.ToInt32(Console.ReadLine());
                if (inputedpin == mypin)
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
}
