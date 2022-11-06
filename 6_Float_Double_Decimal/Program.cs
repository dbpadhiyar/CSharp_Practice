using System;

class Program
{
    public static void Main()
    {
        float price = 1234567.92345f; // will take only 8 digit 
        Console.WriteLine("Price Is => {0}",price);

        double amount = 123456789101112; // will take only 15 digit safely
        Console.WriteLine("Price Is => {0}", amount);        

        decimal gdp = 123456789123456789.1234567891234m; // will take only 29 digit
        Console.WriteLine("Gdp Is => {0}", gdp);
        Console.ReadLine();
    }
}