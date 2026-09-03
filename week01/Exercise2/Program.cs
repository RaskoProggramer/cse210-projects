using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter grade as percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";

        if (grade >= 90)
        {
            if (grade >= 93)
            {
                letter = "A";
            }
            else if (grade >= 90)
            {
                letter = "A-";
            }
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade >= 83)
            {
                letter = "B";
            }
            else if (grade >= 80)
            {
                letter = "B-";
            }
        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade >= 73)
            {
                letter = "C";
            }
            else if (grade >= 70)
            {
                letter = "C-";
            }
        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade >= 63)
            {
                letter = "D";
            }
            else if (grade >= 60)
            {
                letter = "D-";
            }
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Grade: {letter}");
    }
}