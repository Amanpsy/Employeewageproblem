using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int part_time = 1;
            int full_time = 2;
            int empcheck;

            Random random = new Random();
            empcheck = random.Next(0, 3);

            if (empcheck == 0)
            {
                Console.WriteLine("Employe is absent");
            }
            else if (empcheck == 1)
            {
                Console.WriteLine("Employee is working part time");
            }
            else
                    {
                Console.WriteLine("Employee is working full time ");
            }
        }
    }
}
