using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project22
{
    internal class Program
    {
        static void getDate(int d,int m,int y)
        {
            int numberOfDays = 0;
            String month = "";
            if (y % 4 == 0 && y % 100 != 0)
            {
                switch (m)
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
                switch (m)
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
            if (d > numberOfDays)
            {
                Console.WriteLine($"The Entered Date {d}/{m}/{y} is wrong as {month} contains only {numberOfDays} Number of days!");
            }
            else
            {
                Console.WriteLine($"The month Of This Date {d}/{m}/{y} that is {d}/{month}/{y} and Number Of Days of That dates Month is {numberOfDays}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter You Entry For Date , Month and Year ,  and send those data to getDate() Funtion");
            int d, m, y;
            d=int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            y= int.Parse(Console.ReadLine());
            getDate(d, m, y);
        }
    }
}
