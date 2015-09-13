using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Graded 9/10 Missing requirement to display the BMI Values from Dept of Health.  It is very important to make sure your programs meet all requirements, this is key when working as a programmer.

namespace BMI
{
    //Angela Kuczynski
    //Assignment 3.31
    //BMI calculator


    using System;

    public class Calculator
    {
        //Main method begins execution of C# app
        public static void Main(string[] args)
	{
		int weight; //declare variable for weight
		int height; //declare variable for height
		int bmi; //declare variable for bmi
		
		//prompt user to enter weight
		Console.Write( "Enter your weight in pounds:  ");
		weight = Convert.ToInt32( Console.ReadLine() );
		
		//prompt user to enter height
		Console.Write("Enter your height in inches: ");
		height = Convert.ToInt32( Console.ReadLine() );
		
		//Calculates BMI
        bmi = (weight * 703) / (height * height);
		
		if (bmi <= 18.5)
			Console.WriteLine( "You are underweight");
		
		if (bmi > 18.5 && bmi< 24.9)
			Console.WriteLine("You are normal weight");
			
		if (bmi > 25 && bmi < 29.9)
			Console.WriteLine("You are overweight");
			
		if (bmi >= 30)
			Console.WriteLine("You are Obese");
			
	} //end Main
        //end class Calculator
    }

}
