using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {


        bool runProgram = true;
        while (runProgram)
        {
            string menu = "\nMenu options:\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit";
            Console.WriteLine(menu);
            Console.Write("Select a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (userInput)
            {
                case 1: //Breathing Activity
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.Run();
                    // breathingTime += 1;
                    break;
                
                case 2: //Reflecting Activity
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.Run();
                    // reflectingTime += 1;
                    break;

                case 3: //Listing Activity
                    ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.Run();
                    // listingTime += 1;
                    break;

                case 4: //Quit
                    Console.WriteLine("Thanks for using the Mindfulness app!");
                    runProgram = false;
                    break;                  
            }

        }
    }
}