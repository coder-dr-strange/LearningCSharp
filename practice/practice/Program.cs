 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main()
        {
            int day = 9;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    goto case 2;
                case 2:
                    Console.WriteLine("Tuesday");
                    goto case 3;

                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                default :
                    Console.WriteLine("Invalid day");
                    break;
                    Console.ReadLine();
            }
            int m = 0;

            while(m <= 15)
            {
                Console.WriteLine(m);
                m++;
                    }
        }
    }
}
