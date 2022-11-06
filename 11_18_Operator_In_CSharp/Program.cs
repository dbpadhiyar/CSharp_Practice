using System;

public class Program
{    

    public static void Main()
    {
        int a,b,c,d,e,finalValue, operand_1, operand_2;        
        a = 45;
        b = 6;
        c = 4;
        d = 50;
        e = 70;
        operand_1 = 15;
        operand_2 = 30;
        /* Arithmatic operator */

        Console.WriteLine("------------   Arithmatic Operator Start ------------");
        Console.WriteLine("Addition of A and B is {0}",a+b);
        Console.WriteLine("Subtraction of A and B is {0}",a-b);
        Console.WriteLine("Multiplication of A and B is {0}",a*b);
        Console.WriteLine("Divison of A and B is {0}",a/b);
        Console.WriteLine("Modulo of A and B is {0}",a%b);        
        Console.WriteLine("------------   Arithmatic Operator End   ------------\n");

        Console.WriteLine("------------   Relational Operator Start ------------");
        Console.WriteLine("A is Greater Than B => {0} ",a>b);
        Console.WriteLine("A is Greater Than B => {0}", a > b);
        Console.WriteLine("A is Greater Than or equal to B => {0}", a >= b);
        Console.WriteLine("A is Less Than B => {0}", a < b);
        Console.WriteLine("A is Less Than or equal to B => {0}", a <= b);
        Console.WriteLine("A is equal to B => {0}", a == b);
        Console.WriteLine("A is Not equal to B => {0}", a != b);
        Console.WriteLine("------------   Relational Operator End   ------------\n");

        Console.WriteLine("------------   Logical Operator Start ------------");
        Console.WriteLine("a greater than b and c => {0}",a>b && a>c);
        Console.WriteLine("b greater than a or c => {0}", b > a || b > c);
        Console.WriteLine("------------   Logical Operator End   ------------\n");

        Console.WriteLine("------------   Assignment Compound Operator Start ------------");
        Console.WriteLine("Addition of A and B using Assignment operator is {0}", a += b);
        Console.WriteLine("Subtraction of A and B using Assignment operator is {0}", a -= b);
        Console.WriteLine("Multiplication of A and B using Assignment operator is {0}", a *= b);
        Console.WriteLine("Divison of A and B using Assignment operator is {0}", a /= b);
        Console.WriteLine("Modulo of A and B using Assignment operator is {0}", a %= b);
        Console.WriteLine("------------   Assignment Compound Operator End   ------------\n");

        Console.WriteLine("------------   Increment Decrement Operator Start ------------");
        d = d++;        
        Console.WriteLine("Increment operator on D++ value is {0}", d);
        d = ++d;
        Console.WriteLine("Increment operator on ++D value is {0}", d);
        e = e++;
        Console.WriteLine("Increment operator on E-- value is {0}", e);
        e = ++e;
        Console.WriteLine("Increment operator on --E value is {0}", e);
        Console.WriteLine("------------   Increment Decrement Operator End   ------------\n");

        Console.WriteLine("------------   Increment Decrement Operator Start ------------");
        Console.WriteLine(@"Ternary operator to assign value to variable 'finalValue' is => {0}", finalValue = operand_1 > operand_2 ? operand_1 : operand_2);
        Console.WriteLine("------------   Increment Decrement Operator End   ------------\n");

        Console.WriteLine("------------   Operator Precedence Start ------------");
        finalValue = (operand_1 + operand_2) + operand_1 - operand_2;
        Console.WriteLine("Answer after operator precedence => {0}", finalValue);
        Console.WriteLine("------------   Operator Precedence End   ------------\n");
        Console.ReadLine();
    }
}