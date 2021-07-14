/*Twenty students were asked to rate on a scale of 1 to 5 the quality of the food in the
  student cafeteria, with 1 being “awful” and 5 being “excellent.” Place the 20 responses
  in an integer array and determine the frequency of each rating.
*/
using System;

class Fig_8_8
{
    public static void Main(string[] args)
    {
        int[] responses = {1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2, };
        int[] frequency = new int[6];

        for (int i = 0; i < responses.Length; i++)
        {
            try
            {
                ++frequency[responses[i]];
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("    responses({0}) = {1}\n", i, responses[i]);
            }
        }
        Console.WriteLine("{0}{1,10}", "Rating", "Frequency");

        for (int rating = 1; rating < frequency.Length; ++rating)
             Console.WriteLine("{0,6}{1,10}", rating, frequency[rating]);

        Console.ReadLine();
    }
}
