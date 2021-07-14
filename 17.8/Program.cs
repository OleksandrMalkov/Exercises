/*17.8 (Student Poll) Figure 8.8 contains an array of survey responses that’s hard-coded into the program. Suppose we wish to process survey results that are stored in a file.
       First, create a Windows Form that prompts the user for survey responses and outputs each response to a file. Use StreamWriter to create a file called numbers.txt.
       Each integer should be written using method Write. Then add a TextBox that will output the frequency of survey responses.
       You should modify the code in Fig. 8.8 to read the survey responses from numbers.txt. The responses should be read from the file by using a StreamReader.
       Class string’s Split method should be used to split the input string into separate responses, then each response should be converted to an integer.
       The program should continue to read responses until it reaches the end of file. The results should be output to the TextBox.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\C#\Exercises\17.8\numbers.txt";
            string resultFromFile;
            int[] responses = new int[10];
            int[] frequency = new int[6];

            using (StreamWriter result = new StreamWriter(path))     //input valid data to file
            {
                int answer;
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        Console.WriteLine("Rate on a scale of 1 to 5 the quality of the food in the student cafeteria: ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        if (answer >= 1 && answer <= 5)
                        {
                            result.Write(answer);
                            result.Write(' ');
                        }
                        else
                        {
                            Console.WriteLine("Rate a scale of 1 to 5 only!");
                            i--;
                        }
                    }
                    catch (FormatException
                    )
                    {
                        Console.WriteLine("Rate only with integers!");
                        i--;
                    }
                }
            }
            using (StreamReader result = new StreamReader(path))    //output data from file to string array
            {
                resultFromFile = result.ReadLine();
            }
            string[] arrayResults = resultFromFile.Split(' ');
            try
            {
                for (int i = 0; i < arrayResults.Length; i++)           //convert each responce to integer
                {
                    responses[i] = Convert.ToInt32(arrayResults[i]);
                }
            }
            catch (Exception) 
            {
            }

            for (int i = 0; i < responses.Length; i++)
            {
                ++frequency[responses[i]];
            }
            Console.WriteLine("{0}{1,10}", "Rating", "Frequency");          //output survey results 

            for (int rating = 1; rating < frequency.Length; ++rating)
                Console.WriteLine("{0,6}{1,10}", rating, frequency[rating]);


            Console.ReadKey();
        }
    }
}




