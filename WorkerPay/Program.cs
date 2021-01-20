using System;

namespace WorkerPay
{
    class Program
    {
        static void Main(string[] args)
        {
            double numH = 0;
            bool count = false;
            double pay = 0;
            bool repeat = false;
            var cont = "";
            Pay obj = new Pay();
            while (repeat == false)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Enter name of Worker");
                var name = Console.ReadLine();



                while (count == false)
                {
                    try
                    {
                        Console.WriteLine("Enter the number of hours " + name + " worked");
                        numH = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The value you have entered is invalid");
                        count = true;
                    }


                    if (count == false)
                    {
                        try
                        {
                            Console.WriteLine("Enter the pay " + name + " gets per hour");
                            pay = double.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The number of hours is invalid");
                            count = true;
                        }
                    }


                    count = true;

                }
                Console.WriteLine(name + " has earned R" + obj.tPay(numH, pay));

                Console.WriteLine("Would you like to calculate another worker's pay? (y/n) ");
                cont = Console.ReadLine();
                if (cont == "n" || cont == "N")
                {
                    repeat = true;
                }
                else if (cont == "Y" || cont == "y")
                {
                    repeat = false;
                    count = false;
                }
                else
                {
                    Console.WriteLine("Invalid entry, Program is starting again. ");
                }



            }

        }
    }
}
