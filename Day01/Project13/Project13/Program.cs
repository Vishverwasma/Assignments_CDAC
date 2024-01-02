using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Project13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dd, mm, yy, numberOfDays = 0;
            string month = "";
            Console.WriteLine("This is a Program To Determine The number Of days in a Month !");
            Console.WriteLine("Date : ");
            dd = int.Parse(Console.ReadLine());
            Console.WriteLine("Month : ");
            mm = int.Parse(Console.ReadLine());
            Console.WriteLine("Year : ");
            yy = int.Parse(Console.ReadLine());

            if (yy % 4 == 0 && yy % 100 != 0)
            {
                switch (mm)
                {
                    case 1:
                        numberOfDays = 31;
                        month = "January";
                        break;
                    case 2:
                        numberOfDays = 29;
                        month = "Feburary";
                        break;
                    case 3:
                        numberOfDays = 31;
                        month = "March";
                        break;
                    case 4:
                        numberOfDays = 30;
                        month = "April";
                        break;
                    case 5:
                        numberOfDays = 31;
                        month = "May";
                        break;
                    case 6:
                        numberOfDays = 30;
                        month = "June";
                        break;
                    case 7:
                        numberOfDays = 31;
                        month = "July";
                        break;
                    case 8:
                        numberOfDays = 31;
                        month = "August";
                        break;
                    case 9:
                        numberOfDays = 30;
                        month = "September";
                        break;
                    case 10:
                        numberOfDays = 31;
                        month = "October";
                        break;
                    case 11:
                        numberOfDays = 30;
                        month = "November";
                        break;
                    case 12:
                        numberOfDays = 31;
                        month = "December";
                        break;
                    default:
                        Console.WriteLine("You Have Entered Invalid Month !");
                        break;
                }
            }
            else
            {
                switch (mm)
                {
                    case 1:
                        numberOfDays = 31;
                        month = "January";
                        break;
                    case 2:
                        numberOfDays = 28;
                        month = "Feburary";
                        break;
                    case 3:
                        numberOfDays = 31;
                        month = "March";
                        break;
                    case 4:
                        numberOfDays = 30;
                        month = "April";
                        break;
                    case 5:
                        numberOfDays = 31;
                        month = "May";
                        break;
                    case 6:
                        numberOfDays = 30;
                        month = "June";
                        break;
                    case 7:
                        numberOfDays = 31;
                        month = "July";
                        break;
                    case 8:
                        numberOfDays = 31;
                        month = "August";
                        break;
                    case 9:
                        numberOfDays = 30;
                        month = "September";
                        break;
                    case 10:
                        numberOfDays = 31;
                        month = "October";
                        break;
                    case 11:
                        numberOfDays = 30;
                        month = "November";
                        break;
                    case 12:
                        numberOfDays = 31;
                        month = "December";
                        break;
                    default:
                        Console.WriteLine("You Have Entered Invalid Month !");
                        break;
                }
            }
            if (dd > numberOfDays)
            {
                Console.WriteLine($"The Entered Date {dd}/{mm}/{yy} is wrong as {month} contains only {numberOfDays} Number of days!");
            }
            else
            {
                Console.WriteLine($"The month Of This Date {dd}/{mm}/{yy} is {month} and Number Of Days of That dates Month is {numberOfDays}");
            }
        }
    }
}
