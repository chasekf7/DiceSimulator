namespace DiceSimulator
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls = GetValidNumber();
            DiceRoller roller = new DiceRoller();
            int[] rollResults = roller.RollDice(numberOfRolls);
            DisplayHistogram(rollResults, numberOfRolls);
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
        
        static int GetValidNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.Write("Please enter a valid positive number: ");
            }

            return number;
        }

        static void DisplayHistogram(int[] results, int totalRolls)
        {
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.");

            for (int sum = 2; sum <= 12; sum++)
            {
                double percentage = (double)results[sum] / totalRolls * 100;
                int numberOfStars = (int)Math.Round(percentage);
                Console.Write($"{sum,2}: "); 
                for (int i = 0; i < numberOfStars; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
            Console.WriteLine(); 
        }}}
