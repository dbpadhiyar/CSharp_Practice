using System;

class Program
{
    public static void Main()
    {
        //simple for loop
        for(int i =0;i <= 10; i++)
        {
            Console.WriteLine("Value of I is => {0}",i);
        }

        // Star Pattern
        for(int j = 1; j <= 5; j++)
        {
            for (int k = 1; k <=j; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("\n");

        //Reverse Star Pattern
        for(int l = 1; l <= 5; l++)
        {
            for(int m = 5;l<= m; m--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("\n");

        //for loop in int array
        int[] marks = new int[10];        
        marks[0] =  12;
        marks[1] =  13;
        marks[2] =  14;
        marks[3] =  15;
        marks[4] =  16;
        marks[5] =  17;
        marks[6] =  18;
        marks[7] =  19;
        marks[8] =  20;
        marks[9] = 21;

        for(int n =0; n <marks.Length; n++)
        {            
            Console.WriteLine("marks for student {0} is {1}", n+1, marks[n]); 
        }
        Console.WriteLine("\n");

        //While Loop
        int p = 0;
        while(p < 10)
        {
            Console.WriteLine("value of P is =>{0}",p);
            p++;
        }

        // Do While Loop
    }
}