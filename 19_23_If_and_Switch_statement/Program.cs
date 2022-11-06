using System;

public class Program
{
    enum dayPart
    {
        winter = 1,
        summer = 2,
        monsoon = 3
    }

    public static void Main()
    {
        int a, b, c, d, e;
        a = 10;
        b = 20;
        c = 30;
        d = 40;
        e = 50;

        Console.WriteLine("--------------- If Loop Start ---------------");
        if (b > a)
        {
            Console.WriteLine("B is Greater Than A");
        }

        Console.WriteLine("--------------- If Loop End   ---------------\n");

        Console.WriteLine("------------- If Else Loop Start -------------");
        if (a < b)
            Console.WriteLine("A is Less Than B");
        else
            Console.WriteLine("B is Greater Than A");
        Console.WriteLine("------------- If Else Loop End   -------------\n");

        Console.WriteLine("---------- Nested If Else Loop Start ----------");
        if (a > b && a > c)
            Console.WriteLine("A is Greater Than B And C");
        else if (b > a && b > c)
            Console.WriteLine("B is Greater Than A And C");
        else if (c > a && c > b)
            Console.WriteLine("C is Greater Than A And B");
        Console.WriteLine("---------- Nested If Else Loop End   ----------\n");

        Console.WriteLine("-----  Switch & Nested Switch Statement Start  -----");

        int dayOfWeek = 1;

        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("It's Monday");
                switch (dayPart.monsoon)
                {
                    case dayPart.winter:
                        Console.WriteLine("it's Monday of {0}", dayPart.winter);
                        break;
                    case dayPart.summer:
                        Console.WriteLine("it's Monday of {0}", dayPart.summer);
                        break;
                    case dayPart.monsoon:
                        Console.WriteLine("it's Monday of {0}", dayPart.monsoon);
                        break;
                }
                break;
            case 2:
                Console.WriteLine("It's Tuesday");
                break;
            case 3:
                Console.WriteLine("It's Wednesday");
                break;
            case 4:
                Console.WriteLine("It's Thursday");
                break;
            case 5:
                Console.WriteLine("It'sss Friday");
                break;
            case 6:
                Console.WriteLine("It'ssssss Saturday");
                break;
            case 7:
                Console.WriteLine("It's Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }
        Console.WriteLine("-----  Switch & Nested Switch Statement End    -----\n");
    }
}