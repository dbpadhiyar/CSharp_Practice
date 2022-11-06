using System;

public class Program
{
    static int count = 0;
    static string  result = string.Empty;
    public static void Main()
    {
        Console.WriteLine("Welcome To MArksheet Maker");

        Console.WriteLine("Please Enter Your Name");
        string studentName = Console.ReadLine();

        Console.WriteLine("Please Enter Your Standard");
        string studentStandard = Console.ReadLine();

        Console.WriteLine("Enter Your Maths Mark");
        int mathsMark = int.Parse(Console.ReadLine());
        if (mathsMark < 33)
            count++;

        Console.WriteLine("Enter Your Science Mark");
        int ScienceMark = int.Parse(Console.ReadLine());
        if (ScienceMark < 33)
            count++;

        Console.WriteLine("Enter Your Social Science  Mark");
        int socialScienceMark = int.Parse(Console.ReadLine());
        if (socialScienceMark < 33)
            count++;

        Console.WriteLine("Enter Your Language Mark");
        int languageMark = int.Parse(Console.ReadLine());
        if (languageMark < 33)
            count++;

        Console.WriteLine("Enter Your Sports Mark");
        int sportsMark = int.Parse(Console.ReadLine());
        if (languageMark < 33)
            count++;

        Console.WriteLine("----------------  Marksheet  ----------------\n\n");
        Console.WriteLine("Student Name : {0}", studentName);
        Console.WriteLine("Standard : {0} \n", studentStandard);
        Console.WriteLine("Maths : {0}", mathsMark);
        Console.WriteLine("Science : {0}", ScienceMark);
        Console.WriteLine("Social Science : {0}", socialScienceMark);
        Console.WriteLine("Language : {0}", languageMark);
        Console.WriteLine("Sports : {0}", sportsMark);

        int totalMark = mathsMark + ScienceMark + socialScienceMark + languageMark + sportsMark;
        float percentage = totalMark / 5f;
        if (count > 0)
            result = $"You Failed in {count} Subject";
        else
            result = $"You Passed Exam With {percentage} Percentage";
        Console.WriteLine(@"Final Result => {0}", result);
        Console.WriteLine("\n\n");
        Console.WriteLine("----------------------------------------------");
    }
}