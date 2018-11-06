using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 1000; i++)
            {
                var response = "";
                if (i % 3 == 0)
                {
                    response += "Fizz";
                }

                if (i % 5 == 0)
                {
                    response += "Buzz";
                }

                if (i % 7 == 0)
                {
                    response += "Bang";
                }

                if (i % 11 == 0)
                {
                    Console.WriteLine("Bong");
                    continue;
                }

                if (response == "")
                {
                    response = i.ToString();
                }
                Console.WriteLine(response);
            }
        }
    }
}
