using System;

class Program
{
    static void Main(string[] args)
    {
        bool cont = true;

        while(cont)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start reflecting activity");
            Console.WriteLine("3.Start listing activity");
            Console.WriteLine("4.Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.Run();
            } else if (option == "2")
            {
                ReflectingActivity reflect1 = new ReflectingActivity();
                reflect1.Run();
            } else if (option == "3")
            {
                ListingActitivity list1 = new ListingActitivity();
                list1.Run();
            } else if (option == "4")
            {
                cont = false;
            } else 
            {
                Console.WriteLine("An error has occurred. Restart the application.");
            }
        }

        
    }
}