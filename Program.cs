using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using mission1;
// Cody Nettesheim 
// Section 001 

internal class Program
{
    internal static Random random = new Random();

    public static void Main(string[] args)
    {
        int numRolls = 0; // set the variable 

        //Welcome lines to the game
        Console.WriteLine("Welcome to the dice rolling game!");

        Console.WriteLine("How many times do you want to roll? ");

        // set the inputted by the user to numRolls
        numRolls = int.Parse(Console.ReadLine());

        Console.WriteLine("Total Number of Rolls = " + numRolls);


        // Create an instance of the rolldice class and call the rolling method
        rolldice diceRoller = new rolldice();

        // Call the Rolling method using the instance
        int[] results = diceRoller.Rolling(numRolls);

        // call the histo function to make a histogram
        Histo(results, numRolls);

    }

    // histogram function
    public static void Histo(int[] Rolled, int numRolls)
    {
        // writing some info/instructions for the user
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        // for loop to count the percentages on each time a number was rolled
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            // defines percentage and makes a percentage out of each array number 
            int percentage = Rolled[iCount] * 100 / numRolls;

            // repeats the * the same aomount of times it's equal to the percentage
            string stars = new string('*', percentage);
            // prints out for the user
            Console.WriteLine($"{iCount}: {stars}");
        }

        Console.WriteLine("Thank for playing!");
    }
}
