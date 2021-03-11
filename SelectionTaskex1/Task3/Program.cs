using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number");
            string num1 = Console.ReadLine();

            Console.WriteLine("Second Number");
            string num2 = Console.ReadLine();

            int num1int = int.Parse(num1); 
            int num2int = int.Parse(num2);

            int sum = num1int + num2int;

            if (sum != 10){
                if (sum < 10){
                    Console.WriteLine("Sum of numbers is less than 10");
                }
                else{
                    Console.WriteLine("Sum of numbers is more than 10");
                }
            }
            else{
                Console.WriteLine("Sum of numbers is equal to 10");
            }
        }
    }
}
