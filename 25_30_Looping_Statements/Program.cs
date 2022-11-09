using System;

class Program
{
    public static void Main()
    {
        //simple for loop
        Console.WriteLine("--------------------- Simple For loop STR---------------------");
        for (int i =0;i < 10; i++)
        {
            Console.WriteLine("Value of I is => {0}",i);
        }
        Console.WriteLine("--------------------- Simple For loop END---------------------");
        Console.WriteLine("\n");

        // Star Pattern
        Console.WriteLine("--------------------- Normal star pattern STR---------------------");
        for (int j =0;j < 10; j++)
        {
            for(int k =0;k <= j; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("--------------------- Normal star pattern END---------------------");
        Console.WriteLine("\n");

        //Reverse Star Pattern
        Console.WriteLine("--------------------- Reverse star pattern STR---------------------");
        for (int m = 0; m <= 10 ; m++)
        {
            for(int n = 10; m <= n ; n--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("--------------------- Reverse star pattern END---------------------");
        Console.WriteLine("\n");

        //for loop in int array
        Console.WriteLine("--------------------- For loop With Int Array STR---------------------");        
        int[] marks = new int[10];        
        marks[0] =  11;
        marks[1] =  12;
        marks[2] =  13;
        marks[3] =  14;
        marks[4] =  15;
        marks[5] =  16;
        marks[6] =  17;
        marks[7] =  18;
        marks[8] =  19;
        marks[9] =  20;

        for(int n =0; n <marks.Length; n++)
        {            
            Console.WriteLine("marks for student {0} is {1}", n+1, marks[n]); 
        }
        Console.WriteLine("--------------------- For loop With Int Array END---------------------");
        Console.WriteLine("\n");


        //While Loop
        Console.WriteLine("--------------------- While loop STR---------------------");
        int p = 0;
        while(p < 10)
        {
            Console.WriteLine("value of P is =>{0}",p);
            p++;
        }
        Console.WriteLine("--------------------- While loop END---------------------");
        Console.WriteLine("\n");

        // Do While Loop
        //=> always execute once even condition is not satisfied
        Console.WriteLine("--------------------- DO While loop STR---------------------");
        int a = 1;

        do
        {
            Console.WriteLine("value of i is => {0}",a);
            a++;
        }
        while (a <0) ;
        Console.WriteLine("--------------------- DO While loop END---------------------");
        Console.WriteLine("\n");

        Console.WriteLine("--------------------- DO While loop Example STR---------------------");
        string decision = string.Empty;
        do
        {
            Console.WriteLine("Enter Price of first Product");
            int firstProductPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of Second Product");
            int secondProductPrice = int.Parse(Console.ReadLine());
            int totalPrice = firstProductPrice + secondProductPrice;
            Console.WriteLine("Total of two product is {0}\n", totalPrice);
            Console.WriteLine("do you want to do total of other pair product");
            decision = Console.ReadLine();
        }
        while(decision.ToUpper() == "YES") ;
        Console.WriteLine("Thank you for using pair calculator");
        Console.WriteLine("--------------------- DO While loop Example END---------------------");
        Console.WriteLine("\n");
    }
}