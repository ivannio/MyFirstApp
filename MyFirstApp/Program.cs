using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name");
             var userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!");
            Console.ReadLine();

            if (userName == "Ivan")
            {
                Console.WriteLine("Wow you know your name! Great job, you're a real winner!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.ReadLine();

            //var i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine($"Current value of i is {i++}");
            //}

            //for (var j = 0; j < 10; j++)
            //{
            //    Console.WriteLine($"Current value of j is {j}");
            //}

            foreach (var currentChar in userName)
            {
                if (currentChar == 'i' || currentChar == 'I')
                {
                    continue;
                }


                Console.WriteLine($"the current character in your name is {currentChar}");
            }

            switch (userName)
            {
                case "Ivan":
                    Console.WriteLine("It's ya boi Ivan");
                    break;
                default:
                    Console.WriteLine("I can't beleive it's not Ivan");
                    break;
            }
        }
    }
}
