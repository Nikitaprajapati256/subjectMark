using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subjectMark
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. calculate  total marks and percentage and decide the grade

                   Console.WriteLine("Enter subject 1 marks :");
             int marks1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter subject 2 marks :");
             int marks2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter subject 3 marks :");
             int marks3 = Convert.ToInt32(Console.ReadLine());

             int total = marks1 + marks2 + marks3;
             double avg = (double)total / 300;
             double percentage = (double)avg * 100;

             Console.WriteLine($"Total marks = {total} \n percentage = {percentage}");

             if (percentage > 75)
             {
                 Console.WriteLine("Your grade A");
             }
             else if(percentage>50 && percentage <= 75)
             {
                 Console.WriteLine("Your Grade B");
             }
             else if(percentage>40 && percentage <= 50)
             {
                 Console.WriteLine("YourGrade C");
             }
             else
             {
                 Console.WriteLine("you are fail");
             }

            //2.Check leap year

             Console.WriteLine("Enter the year you want to check for Leap year");
             int year= Convert.ToInt32(Console.ReadLine());

             if ((year % 400) == 0)
             {
                 Console.WriteLine($"{year} is Leap Year");

             }
             else if((year%100)==0)
             {
                 Console.WriteLine($"{year} is not Leap Year");
             }
             else if ((year % 4) == 0)
             {
                 Console.WriteLine($"{year} is Leap Year");

             }
             else
             {
                 Console.WriteLine($"{year} is not Leap Year");
             }

            //3. Calculate Lagest number from given number

             Console.WriteLine("Enter any three numbers");
             int num1=Convert.ToInt32(Console.ReadLine());
             int num2 = Convert.ToInt32(Console.ReadLine());
             int num3 = Convert.ToInt32(Console.ReadLine());

             if (num1 > num2)
             {
                 if (num1 > num3)
                 {
                     Console.WriteLine($"{num1} is Largest");
                 }
                 else
                 {
                     Console.WriteLine($"{num3} is Largest");
                 }
             }
             else if(num2 > num3)
             {
                 Console.WriteLine($"{num2} is Largest");
             }
             else
             {
                 Console.WriteLine($"{num3} is Largest");
             }


            //4.calculate loss and profit

             Console.WriteLine("Enter cost price ");
             int cprice=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter selling price");
             int sprice=Convert.ToInt32(Console.ReadLine());

             if (sprice > cprice)
             {
                 int profit = sprice - cprice;
                 Console.WriteLine($"your total profit  = {profit} ");
             }
             else
             {
                 int loss=cprice-sprice;
                 Console.WriteLine($"Your loss = {loss}");
             }
             
            //5.week day from number

            Console.WriteLine("Enter a week day number");
            int number= Convert.ToInt32(Console.ReadLine());

            if(number==0 )
            {
                Console.WriteLine("sunday");
            }
            else if(number==1 )
            {
                Console.WriteLine("Monday");
            }
            else if(number==2 )
            {
                Console.WriteLine("Tuesday");
            }
            else if(number==3 )
            {
                Console.WriteLine("Wednesday");
            }
            else if(number==4 )
            {
                Console.WriteLine("Thursday");
            }
            else if(number==5 )
            {
                Console.WriteLine("Friday");
            }
            else if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Given number is invalid");
            }



        }
    }
}
