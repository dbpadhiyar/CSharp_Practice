using System;

class Program
{
    static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine("{0:d}", dt); //09-10-2022
        Console.WriteLine(dt.ToString("ddd/mm/yyyy"));
        Console.ReadLine();

    }
}