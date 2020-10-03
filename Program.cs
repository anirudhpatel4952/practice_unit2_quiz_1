using System;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age to know the price of the movie ticket");
            int age = Convert.ToInt32(Console.ReadLine());
            string price = "";
            
            if (age <= 5) {
                price = "free";  
                Console.WriteLine("The price for your movie ticket is " + price);
            }
            else if (age > 5 && age < 14) {
                price = "$7.99";
                Console.WriteLine("The price for your movie ticket is " + price);
            }
            else if (age > 14 && age < 65) {
                price = "$11.99";
                Console.WriteLine("The price for your movie ticket is " + price);
            }
            else if (age > 65) {
                price = "$9.99";
                Console.WriteLine("The price for your movie ticket is " + price);
            }
            
        }
    }
}
