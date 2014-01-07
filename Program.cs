using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleWeekday
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //Declare variables
            Int32 iDay = 0;
            Random rnd = new Random();
            String sDay = String.Empty;

            //Generate a random integer in the range 1-7, inclusive
            iDay = rnd.Next(1, 8);
            sDay = iDay.ToString();

            switch (iDay)
            {
                case 1:
                    Pause("Sunday");
                    break;
                case 2:
                    Pause("Monday");
                    break;
                case 3:
                    Pause("Tuesday");
                    break;
                case 4:
                    Pause("Wednesday");
                    break;
                case 5:
                    Pause("Thursday");
                    break;
                case 6:
                    Pause("Friday");
                    break;
                case 7:
                    Pause("Saturday");
                    break;
                default:
                    Pause("Problem!");
                    break;
            }

        }
        static void Pause(String s)
        {
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
