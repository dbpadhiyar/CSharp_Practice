using System;

class Program
{
    static void Main()
    {
        //Escape Sequence Uses Are Lisyed Below

        Console.WriteLine("Escape sequence is useful to print some special keyword or comma");
        Console.WriteLine("\"Hello World\""); // (\" => will Print ")
        Console.WriteLine("\'Hello DP\'");    // (\' => will print ')
        Console.WriteLine("\none\nTwo\nThree"); // (\n => will start new line)
        Console.WriteLine("Hello\tThere\tHow\tAre\tYou?");  // (\t => will Consider as Tab)

        //Verbatim Literal => VL Help you to remove escape sequence and print string as it is (consider as normal character)

        string videoPath = @"D:\NEW\TV\1.MP4";
        Console.WriteLine(videoPath);
    }
}