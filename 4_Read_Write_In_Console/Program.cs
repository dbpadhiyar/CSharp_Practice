using System;

class Progrmam
{
    public static void Main()
    {
        /*
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Full Name Is : {0} {1}", firstName, lastName); //Place Holder Syntax
            Console.ReadLine(); 

        */


        Console.WriteLine("Enter First Number");
        int firstOperand = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int secondOperand = int.Parse(Console.ReadLine());

        int totalSum = firstOperand + secondOperand;

        Console.WriteLine("Total Is : {0}", totalSum); //Place Holder Syntax
        Console.ReadLine();

    }
}