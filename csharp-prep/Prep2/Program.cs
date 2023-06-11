using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string userGrade = Console.ReadLine();

        double grade = double.Parse(userGrade);

        string letter;
        string signal;
        double remainder = grade % 10;
        

        if (remainder < 3 ) {

            signal = "-" ;

        }

        else if (remainder >= 7) {

            signal = "+";
            
        }

        else {

            signal = "";
        }
        
    
        if (grade >= 90) 
        {
            if (remainder >= 3) {
                letter = "A"; 
            }

            else {

                letter = "A" + signal;
            }
            

        }

        else if (grade >= 80 && grade < 90) 
        {

            letter = "B" + signal;

        }

        else if (grade >= 70 && grade < 80 ) {

            letter = "C" + signal;

        }

        else if (grade >= 60 && grade < 70) {

            letter = "D" + signal;

        }

        else {

            letter = "F";
        }


        if (grade >= 70) {

            Console.WriteLine("Congratulations, you passed!");
        }

        else {

            Console.WriteLine("Not today. You should study a little bit more.");
        }

        Console.WriteLine($"Your grade is {letter}.");
        }
    }