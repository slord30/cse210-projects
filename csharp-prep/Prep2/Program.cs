using System;

class Program
{
    static void Main(string[] args)
    {

        // Ask user for their grade percentage to figure out what grade they received in the class. Print the letter grade. 
        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int grade = int.Parse(userAnswer);

        // create a variable called "letter" to assign the letter grade to 
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter the student got to the screen 
        Console.WriteLine($"Your grade is: {letter}"); 

        // Check to see if the student passed the class. Student must get a 70 or higher to pass. Print to screen if student passed or did not pass. 
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! you passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }


//First part of assignment before creating variable "letter" 
        // // Ask user for their grade percentage to figure out what grade they received in the class. Print the letter grade. 
        // Console.Write("What is your grade percentage? ");
        // string userAnswer = Console.ReadLine();
        // int grade = int.Parse(userAnswer);

        // if (grade >= 90)
        // {
        //     Console.WriteLine("Your grade is: A");
        // }
        // else if (grade >=80)
        // {
        //     Console.WriteLine("Your grade is: B");
        // }
        // else if (grade >= 70)
        // {
        //     Console.WriteLine("Your grade is: C");
        // }
        // else if (grade >= 60)
        // {
        //     Console.WriteLine("Your grade is: D");
        // }
        // else
        // {
        //     Console.WriteLine("Your grade is: F");
        // }

        // // Check to see if the student passed the class. Student must get a 70 or higher to pass. Print to screen if student passed or did not pass. 
        // if (grade >= 70)
        // {
        //     Console.WriteLine("Congratulations! you passed the class.");
        // }
        // else
        // {
        //     Console.WriteLine("Sorry, you did not pass the class.");
        // }

    }
}