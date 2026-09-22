using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserAge();
        }

        static void GetUserAge()
        {


            try
            {
                Console.WriteLine("Please enter your age:");
                string ageInput = Console.ReadLine();
                int age = int.Parse(ageInput);
                Console.WriteLine($"You are {age} years old.");
          
                  

            }
            catch (Exception)
            {
                Console.WriteLine($"Please insert a valid number.");
                string ageInput = Console.ReadLine();
                int age = int.Parse(ageInput);
                Console.WriteLine($"You are {age} years old.");
               
            }

            finally
            {

                Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
           
            }

            GetUserAge();






        }

    }

}









    