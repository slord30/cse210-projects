using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Sarah Lord", "Derivatives");
        Console.WriteLine(assignment1.GetSummary()); 

        MathAssignment math1 = new MathAssignment("Sarah Lord", "Derivatives", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());    

        WritingInformation writing1 = new WritingInformation("Sarah Lord", "Texas History", "All About the Alamo ");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}