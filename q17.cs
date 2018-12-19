using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true; int number = 0;
            while (flag)// this falge turn to false only when we have 3 happy numbers in row 
            {
                number++;
                if(happynumber(number))// check if ther number is happy so print it and check number -1 and number -2 if the three numbres are happy the flag turn to false and print the three numbers in row 
                {
                    Console.WriteLine($" {number } this number is happy number ");
                    if (happynumber(number - 1) && happynumber(number - 2))
                    {
                        Console.WriteLine($"{number} {number - 1} {number - 2}");
                        flag = false;
                    }
                }
            }
            Console.WriteLine(happynumber(1821));

            
        }

         private static bool happynumber(int number)
         {
                int sum = 0, temp;

            while(number!=0)//  while the number diffirent than 0 we take the first digit and power it with 2 tell the sum in from onr digit else we send the sum to the same function again and again until we got sum thats one digit only
            { 
                temp = Convert.ToInt32(Math.Pow(number % 10, 2));
                sum += temp;
                number /= 10;
            
            }
            if (sum>9)// check if the sum is one digit number 
            {
               return happynumber(sum);
            }
            else
            {
                if (sum == 1)
                {
                    return true;

                }
                else
                    return false;
            }
         }
     
    }
}
