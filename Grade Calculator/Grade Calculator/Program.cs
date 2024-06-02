using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
  
namespace GradeConverter
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your numerical grade (0-100): ");
                string input = Console.ReadLine();
                int grade;

                if (int.TryParse(input, out grade))
                {
                    if (grade >= 90 && grade <= 100)
                    {
                        Console.WriteLine("Your letter grade is A");
                    }
                    else if (grade >= 80 && grade < 90)
                    {
                        Console.WriteLine("Your letter grade is B");
                    }
                    else if (grade >= 70 && grade < 80)
                    {
                        Console.WriteLine("Your letter grade is C");
                    }
                    else if (grade >= 60 && grade < 70)
                    {
                        Console.WriteLine("Your letter grade is D");
                    }
                    else if (grade >= 0 && grade < 60)
                    {
                        Console.WriteLine("Your letter grade is F");
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.ReadKey();
            }
        }
    }
}
    