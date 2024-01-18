using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace mission1
{
    class rolldice //make a class called rolldice
    {
        public int[] Rolling(int numRolls) // rolls two dices 
        {
            int[] Rolled = new int[13]; // creates the array with 13 elements

            // for loop going through the amount of the times the user wants to roll the dice
            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                // random number of the first roll
                int randNum1 = Program.random.Next(1, 7);

                // random number of the second roll
                int randNum2 = Program.random.Next(1, 7);

                // adds the two rolls together
                int sum = randNum1 + randNum2;

                Rolled[sum]++; // adds the array to the 
            }
            // returns the rolled array
            return Rolled;
        }
    }
}
