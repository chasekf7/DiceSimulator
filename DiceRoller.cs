namespace DiceSimulator
{
    /// <summary>
    /// DiceRoller class handles the simulation of rolling two 6-sided dice
    /// and tracking the results in an array
    /// </summary>
    public class DiceRoller
    {
        // Random number generator - create once and reuse for better randomness
        private Random random;

        /// <summary>
        /// Constructor initializes the Random object
        /// </summary>
        public DiceRoller()
        {
            random = new Random();
        }

        /// <summary>
        /// Simulates rolling two 6-sided dice for a specified number of times
        /// </summary>
        /// <param name="numberOfRolls">How many times to roll the dice</param>
        /// <returns>An array containing the count of each sum (indices 2-12)</returns>
        public int[] RollDice(int numberOfRolls)
        {
            // Create an array to store results
            // Index 0-1 won't be used (can't roll 0 or 1 with two dice)
            // Index 2-12 will store counts for sums of 2 through 12
            int[] results = new int[13];

            // Roll the dice the specified number of times
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Roll first die (1-6)
                int die1 = random.Next(1, 7); // Next(1, 7) generates numbers 1-6

                // Roll second die (1-6)
                int die2 = random.Next(1, 7);

                // Calculate the sum of both dice
                int sum = die1 + die2;

                // Increment the count for this sum in our results array
                results[sum]++;
            }

            // Return the array with all the counts
            return results;
        }
    }
}
