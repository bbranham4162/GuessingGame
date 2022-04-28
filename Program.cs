// See https://aka.ms/new-console-template for more information
using System;

namespace CheckPoint 
{
    class Program
    {
        static void Main(string[] args)
        {

        
        Console.WriteLine("What was your score? ");

        int score = Int32.Parse(Console.ReadLine());

        string letterGrade ;
        if (score >= 90)
        {
            letterGrade = "A";
        }
        else if (score >= 80)
        {
            letterGrade = "B";
        }
        else if (score >= 70)
        {
            letterGrade = "C";
        }
        else if (score >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.Write($"You got a {letterGrade} in the class");
        }
    }
}
