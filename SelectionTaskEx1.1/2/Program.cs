using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your gender? M/F");
            string gender = Console.ReadLine();

            int agenum = int.Parse(age);

            if (agenum > 17){
                Console.WriteLine(gender + " Legally adult age");
            }
            else{
                Console.WriteLine(gender + " Legally not adult age");
            }
        }
    }
}
