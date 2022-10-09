using System;

class Progrmam
{
    static void Main()
    {
        Console.WriteLine("1 => \t Integral type contain two more type \n 1. Signed Integers(Take Nagative And Positive Value) \n 2. unsigned integer which takes only Positive values");
        Console.WriteLine("sbyte, short, int,long are unsigned integer type");
        Console.WriteLine("byte, ushort,uint,ulong are signed integer type");

        Console.WriteLine("Min value of sbyte is {0}", sbyte.MinValue);
        Console.WriteLine("Max value of sbyte is {0} \n", sbyte.MaxValue);
        Console.WriteLine("Min value of byte is {0}", byte.MinValue);
        Console.WriteLine("Max value of byte is {0} \n", byte.MaxValue);
        Console.WriteLine("Min value of char is {0}", char.MinValue);
        Console.WriteLine("Max value of char is {0} \n", char.MaxValue);
        Console.WriteLine("Min value of short is {0}", short.MinValue);
        Console.WriteLine("Max value of short is {0} \n", short.MaxValue);
        Console.WriteLine("Min value of unasigned short is {0}", ushort.MinValue);
        Console.WriteLine("Max value of unasigned short is {0} \n", ushort.MaxValue); 
        Console.WriteLine("Min value of integer is {0}", int.MinValue);
        Console.WriteLine("Max value of integer is {0} \n", int.MaxValue);
        Console.WriteLine("Min value of unasigned integer is {0}", uint.MinValue);
        Console.WriteLine("Max value of unasigned integer is {0} \n", uint.MaxValue);
        Console.WriteLine("Min value of long is {0}", long.MinValue);
        Console.WriteLine("Max value of long is {0} \n", long.MaxValue);
        Console.WriteLine("Min value of unasigned long is {0}", ulong.MinValue);
        Console.WriteLine("Max value of unasigned long is {0} \n\n", ulong.MaxValue);

        Console.WriteLine("2 => \t boolean data type return only true or false value");

        int lastYearPoint = 22;
        int ThisYearPoint = 35;

        bool winner = ThisYearPoint > lastYearPoint;
         
        Console.WriteLine(winner.GetType()); // TO Find Type of Value
        Console.WriteLine("Our Performance Improved ? => {0}",winner);
    }


}