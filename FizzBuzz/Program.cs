using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to run up to: ");
            var inputStr = Console.ReadLine();
            if (!int.TryParse(inputStr, out var inputNum) || inputNum < 1)
            {
                Console.WriteLine("Input invalid, defaulting to 100");
                inputNum = 100;
            }
            for (var i = 1; i <= inputNum; i++)
            {
                IList<string> responses = new List<string>();
                if (i % 3 == 0)
                {
                    responses.Add("Fizz");
                }

                if (i % 13 == 0)
                {
                    responses.Add("Fezz");
                }

                if (i % 5 == 0)
                {
                    responses.Add("Buzz");
                }

                if (i % 7 == 0)
                {
                    responses.Add("Bang");
                }

                if (i % 11 == 0)
                {
                    responses.Clear();
                    if (i % 13 == 0)
                    {
                        responses.Add("Fezz");
                    }
                    responses.Add("Bong");
                }

                if (responses.Count == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    var response = "";
                    if (i % 17 == 0)
                    {
                        for (var x = responses.Count - 1; x >= 0; x--)
                        {
                            response += responses[x];
                        }
                    }
                    else
                    {
                        foreach (var t in responses)
                        {
                            response += t;
                        }
                    }
                    
                    Console.WriteLine(response);
                }
            }
        }
    }
}
