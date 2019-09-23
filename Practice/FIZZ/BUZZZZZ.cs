using System;
using System.Collections.Generic;
using System.Text;

namespace FIZZ
{
    public class BUZZZZZ
    {
        public void PrintNumbers()
        {
            
            for(int i=0; i<=100; i++)
            {
                string output = GetOutput(i);

                Console.WriteLine(output);
            }
        }

        public string GetOutput(int number)
        {
            string output;

            if (number % 3 == 0)
            {
                output = "FizzBuzz";
            }


            else if (number % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = number.ToString();
            }

            return output;
        }
    }
}

