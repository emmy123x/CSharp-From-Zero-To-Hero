using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string myLastName = Console.ReadLine();

            Console.WriteLine("How old are you");
            string myAge = Console.ReadLine();

            Console.WriteLine("How much do you weigh?");
            string myWeight = Console.ReadLine();

            Console.WriteLine("how tall are you in feet");
            string myHeightFeet = Console.ReadLine();

            Console.WriteLine("how tall are you in inches");
            string myHeightInches = Console.ReadLine();

            Console.WriteLine(myName + " " + myLastName + " is " + myAge + " years old, her weight is "
                + myWeight + " lbs and her height is " + myHeightFeet + " feet " + myHeightInches + " inches.");
            
            double myWeightDouble = Convert.ToDouble(myWeight);
            double myHeightDouble = Convert.ToDouble(myHeightFeet);
            double myHeightDouble2 = Convert.ToDouble(myHeightInches);
            double myBMI = (myWeightDouble / Math.Pow(myHeightDouble * 12 + myHeightDouble2, 2)) * 703;

            Console.WriteLine("With the information you provided we were able to calculate your BMI.");
            Console.WriteLine("Your BMI:" + myBMI.ToString("#.#"));


        }
    }
}
