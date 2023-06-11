using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<double> listNumber = new List<double>();
        double stop = 100;

        while (stop != 0)
        {
                    
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        double number = double.Parse(Console.ReadLine());

            if (number != 0) 
            {
               listNumber.Add(number);
            }
            else
            {
            stop = number;

            } 
        }  ;

        

        Console.WriteLine($"The sum is {listNumber.Sum()}. ");
        Console.WriteLine($"The average is {listNumber.Average()}. ");
        Console.WriteLine($"The largest number is {listNumber.Max()}. ");



    }
}