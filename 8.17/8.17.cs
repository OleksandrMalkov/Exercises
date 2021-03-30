/*8.17 (Dice Rolling) Write an app to simulate the rolling of two dice. The app should use an object of class Random once to roll the first die and again to roll the second die. 
       The sum of the two values should then be calculated. Each die can show an integer value from 1 to 6, so the sum of the values will vary from 2 to 12,
       with 7 being the most frequent sum and 2 and 12 the least frequent sums. Figure 8.24 shows the 36 possible combinations of the two dice. 
       Your app should roll the dice 36,000 times.
       Use a one-dimensional array to tally the number of times each possible sum appears. Display the results in tabular format.
       Determine whether the totals are reasonable (e.g., there are six ways to roll a 7, so approximately one-sixth of the rolls should be 7).
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        int sum;
        Random diceRandom = new Random();

        int[] dice = new int[7];
        int[] arraySum = new int[13];

        for (int roll = 1; roll <= 36000; ++roll)
        {
            sum = diceRandom.Next(1, 7) + diceRandom.Next(1, 7);
            ++arraySum[sum];
        }
        Console.WriteLine("{0}{1,10}", "Sum", "Frequency");
        for (int i = 2; i < arraySum.Length; ++i)
             Console.WriteLine("{0,2}{1,10}", i, arraySum[i]);
        Console.ReadLine();
    }
}
