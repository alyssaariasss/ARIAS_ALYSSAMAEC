using System;

namespace Calculator
{
    class Program
    {

        static void Main()
        {

            double fir_num;
            double sec_num;
            double ans;
            string oprtn;
            char repeat;
       
            
            do
            {
                Console.WriteLine("\n\n\t\t\t\t\t\t---------------------------\n");
                Console.WriteLine("\t\t\t\t\t\tBASIC ARITHMETIC CALCULATOR\n");
                Console.WriteLine("\t\t\t\t\t\t---------------------------\n\n");

                Console.WriteLine("Enter first number:\n");
                fir_num = Double.Parse(Console.ReadLine());

                Console.WriteLine("\nChoose an operator [+ , - , * , /]:\n");
                oprtn = Console.ReadLine();

                Console.WriteLine("\nEnter second number:\n");
                sec_num = Double.Parse(Console.ReadLine());

                Console.WriteLine("\n----------------------------------\n");


                if (oprtn != "+" && oprtn != "-" && oprtn != "*" && oprtn != "/")
                {
                    Console.WriteLine("INVALID OPERATOR. PLEASE TRY AGAIN. \n");
                }

                else
                {
                    if (oprtn == "+")
                    {
                        ans = fir_num + sec_num;
                        Console.WriteLine(ans);
                    }

                    if (oprtn == "-")
                    {
                        ans = fir_num - sec_num;
                        Console.WriteLine(ans);
                    }

                    if (oprtn == "*")
                    {
                        ans = fir_num * sec_num;
                        Console.WriteLine(ans);
                    }

                    if (oprtn == "/")
                    {
                        if (sec_num == 0);
                        {
                            Console.WriteLine("MATH ERROR.\n");
                        }
                        ans = fir_num / sec_num;
                        Console.WriteLine(ans);
                    }

                }
                Console.Write("\nWould you like to try again? Type 'Y' to continue.\n\n");
                repeat = char.Parse(Console.ReadLine());
            } while (repeat == 'Y');

            return;
            Console.ReadKey();
        }
    }
}
