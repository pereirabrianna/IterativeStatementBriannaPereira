using System;

namespace IterativeStatementBriannaPereira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer between 2 and 10: ");

            int y = Convert.ToInt32(Console.ReadLine());

           if (y % 2 == 0)
            {
                for (int i = 1; i < y + 2; i++)
                {
                    Console.WriteLine(i.ToString() + "." + "You entered an even number");
                }
            }
            else
            {
                for ( int i = 1; i < y + 0; i++)
                {
                    Console.WriteLine(i.ToString() + "." + "You entered an odd number");
                }
            }
            }

        }
    }

