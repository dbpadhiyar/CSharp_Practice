using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("There Are Two Type of Convertion 1. Implicit 2. Explicit\n");
        Console.WriteLine("Implicit Convertion Done By C# Compiler By itself\n");
        Console.WriteLine("Explicit Convertion has to be done by our self\n");

        Console.WriteLine("Convertion from small data to large data type are included in implicit Conversion \n\t for Example : int to float\n");

        Console.WriteLine("Implicit Conversation Example");

        int price = 180;
        float rate = price;
        Console.WriteLine("int to float answer is {0}\n", rate);

        double finalPrice = rate + 28.233;
        Console.WriteLine("float to double answer is {0}\n", finalPrice);

        Console.WriteLine("Explicit Conversation Example\n");

        float exPrice = 280.233f;
        int exRate = (int)exPrice; //explicit Data  Type Conversation
        Console.WriteLine("Float to int by using explicit data type conversation {0} \n", exRate);

        exRate = Convert.ToInt32(exPrice); //using Convert Class
        Console.WriteLine("Float to int by using convert class {0} \n", exRate);

        string firstOperand = "110";
        string secondOperand = "222";

        int totalAmount = int.Parse(firstOperand) + int.Parse(secondOperand); //will not able to convert float value
        Console.WriteLine("convert and sum of two variable using parse Method => {0} \n", totalAmount);

        string thirdOperand = "111";
        string fourthOperand = "222t";

        int thirdOperandDefaultValue = 5;
        int fourthOperandDefaultValue = 14;

        bool isThirdValidOperand = int.TryParse(thirdOperand, out thirdOperandDefaultValue);
        bool isFourthValidOperand = int.TryParse(fourthOperand, out fourthOperandDefaultValue);

        int finalAmount = 0;
        string choice = string.Empty;
        if (isThirdValidOperand && isFourthValidOperand)
        {
            choice = "TryParse";
            finalAmount = int.Parse(thirdOperand) + int.Parse(fourthOperand);
        }
        else
        {           
            choice = "Without TryParse";
            finalAmount = thirdOperandDefaultValue + fourthOperandDefaultValue;
        }
        Console.WriteLine("The total of third and fourth is => {0} and it's done by using {1}", finalAmount, choice);
       
    }
}