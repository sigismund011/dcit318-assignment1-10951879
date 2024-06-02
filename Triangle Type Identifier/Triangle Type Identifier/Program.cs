using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    using System;

    namespace TriangleType
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the length of side A: ");
                int sideA = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the length of side B: ");
                int sideB = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the length of side C: ");
                int sideC = Convert.ToInt32(Console.ReadLine());

                // Check conditions to determine the type of triangle based on the lengths of its sides

                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("The triangle is equilateral");
                }
                else if (sideA == sideB || sideB == sideC || sideC == sideA)
                {
                    Console.WriteLine("The triangle is isosceles");
                }
                else
                {
                    Console.WriteLine("The triangle is scalene");
                }

                Console.ReadLine(); // wait for user to press Enter
            }
        }
    }
}
