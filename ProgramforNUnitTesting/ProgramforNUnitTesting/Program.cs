using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramforNUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Programs for NUnit Testing");
            Console.WriteLine("Enter Your Choice \n1.Vending Machine" + "\n2.DayOfWeek" + "\n3.tempratureConversion" + "\n4.MonthlyPayment" + "\n5.squareRoot" + "\n6.DecimaltoBinaryConversion" + "\n7.SwapNibbles" + "\n8.Exit");
            int choice=Convert.ToInt32(Console.ReadLine());   
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the Amount to get Change");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    VendingMachine vendingM = new VendingMachine();
                    vendingM.Getchange(amt);
                    break;
                case 2:
                    DayOfWeek weekday = new DayOfWeek();
                    Console.WriteLine("Enter day");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int Month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    weekday.Day(day, Month, year);
                    break;
                case 3:
                    double celsius, fahrenheit;
                    Console.WriteLine("Enter value for celsius:");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter value for Fahrenheit:");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    temperaturConversion temp = new temperaturConversion();
                    temp.tempConversion(celsius, fahrenheit);
                    break;
                case 4:
                    monthlyPayment monthP = new monthlyPayment();
                    Console.WriteLine("Enter the value of principal");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the year");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the rate : ");
                    double R = Convert.ToDouble(Console.ReadLine());
                    monthP.MonPayment( p, y, R);
                    break;
                case 5:
                    Sqrt.squareRoot();
                    break;
                case 6:
                    BinaryConversion binary = new BinaryConversion();
                    binary.decimalToBinaryConversion();
                    break;
                case 7:
                    SwapNibbles swap = new SwapNibbles();
                    Console.WriteLine("Enter number to convert in Binary :");
                    int number = Convert.ToInt32(Console.ReadLine());
                    swap.ToBinary(number);
                    break;
                default:
                    Console.WriteLine("EXIT");
                    break;






            }
            Console.ReadLine();

        }
    }
}
