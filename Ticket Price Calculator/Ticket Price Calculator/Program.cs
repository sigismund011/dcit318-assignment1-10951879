using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
    using System;

    namespace MovieTicketPrice
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                double ticketPrice;

                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7.0;
                }
                else
                {
                    ticketPrice = 10.0;
                }

                Console.WriteLine($"Your ticket price is GHC{ticketPrice:F2}");
            }
        }
    }

}
