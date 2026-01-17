namespace DiceSimulator
{
    public class DiceRoller
    {
        private Random random;
        public DiceRoller()
        {
            random = new Random();
        }
        public int[] RollDice(int numberOfRolls)
        {
            int[] results = new int[13];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);
                int sum = die1 + die2;
                results[sum]++;
            }
            return results;
        }}}
