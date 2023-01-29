using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {

            string myName = Checks.PromptString("What is your name?");

            string myLastName = Checks.PromptString("What is your last name?"); 

            int myAge = Checks.PromptInt("How old are you");

            double myWeight = Checks.PromptDouble("How much do you weigh?");

            double myHeightFeet = Checks.PromptDouble("how tall are you in feet");

            double myHeightInches = Checks.PromptDouble("how tall are you in inches");

            Console.WriteLine(myName + " " + myLastName + " is " + myAge + " years old, her weight is "
                + myWeight + " lbs and her height is " + myHeightFeet + " feet " + myHeightInches + " inches.");

            
            double myBMI = Checks.CalculateBmi(myWeight, myHeightFeet, myHeightInches);

            Checks.PrintBmi(myBMI, "With the information you provided we were able to calculate your BMI.");
            
        }
    }
}
