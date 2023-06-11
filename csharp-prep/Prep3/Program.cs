using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        int guess ;
        int number;
        Random randomGenerator = new Random();
        number = randomGenerator.Next(0, 100);
        int Counter = 0;
        bool play = true;
        do

        {
            
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            Counter += 1;
            if ( guess > number) {

                Console.WriteLine("Lower");
            }

            else if (guess < number) {
                Console.WriteLine("Higher");
            }

            else {

                Console.WriteLine($"You made {Counter} tries.");
                Console.WriteLine("You guessed it!");
                Console.WriteLine("Do you want play again? (y or n)");
                string again = Console.ReadLine();

                if (again == "n") {

                    play = false;
                    Console.WriteLine("Game Over!");

                }

                else {

                    Console.WriteLine("Let's play again!");
                    play = true;
                    number = randomGenerator.Next(0, 100);
                    Counter = 0;
                    
                }

            }
        }  while (guess != number || play == true);
    }
}