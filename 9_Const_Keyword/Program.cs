using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Const Value Cannot be Changed");
        Console.WriteLine("2. Any Value-type Can be declared as Const");
        Console.WriteLine("3. declaration and initialization done at a time");
        Console.WriteLine("4. \"Const\" Keyword Must Be Applied \n");
        Console.WriteLine("--------------------------OUTPUT---------------------------------------");
        const int Hand = 2;

        Console.WriteLine("You Have Total {0} Hand",Hand);

    }
}