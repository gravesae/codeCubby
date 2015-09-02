//Angela Kuczynski
//Assignment 3.15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Arithmetic
{
    //main method begins execution of C# application
    public static void Main(string[] args)
    {
        int num1; //declare first number to add
        int num2; //declare second number to add
        int sum; //declare sum of num1 and num2
        int product;
        int difference;
        int quotient;

        Console.Write("Please enter first integer: "); //prompt user for first integer
        //read first number from user
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter second integer: "); // prompt user for second integer

        //read second number from user
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2; //add numbers
        product = num1 * num2;//multiply numbers
        difference = num1 - num2; //subtract numbers
        quotient = num1 / num2;//divide numbers

        Console.WriteLine( "Sum is {0}",sum); //display sum
        Console.WriteLine( "Product is {0}",product); //display product
        Console.WriteLine( "Difference is {0}",difference); //display difference
        Console.WriteLine( "Quotient is {0}",quotient); //display quotient
        Console.Read();
    }//end Main
}//end class