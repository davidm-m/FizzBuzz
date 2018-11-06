using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 3315; i++)
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
                        for (var x = 0; x < responses.Count; x++)
                        {
                            response += responses[x];
                        }
                    }
                    
                    Console.WriteLine(response);
                }
            }
        }
    }
}
