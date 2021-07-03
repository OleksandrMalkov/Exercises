/*16.6 (All Possible Three-Letter Words from a Five-Letter Word) Write a program that reads a five-letter word from the user and produces all possible three-letter combinations that can be derived
       from the letters of the five-letter word. For example, the three-letter words produced from the word “bathe” include the commonly used words
       “ate,” “bat,” “bet,” “tab,” “hat,” “the” and “tea,” and the 3-letter combinations “bth,” “eab,” etc.
 */
using System;

class Program
{

    static void Main(string[] args)
    {
        string inputWord = InputtingWord();     //Inputting word with cheking

        for (int l1 = 0; l1 < 5; l1++)
        {
            Console.WriteLine();
            for (int l2 = 0; l2 < 5; l2++)
            {
                for (int l3 = 0; l3 < 5; l3++)
                {
                    if (l1 != l2 && l1 != l3 && l2 != l3)
                        Console.Write(inputWord.Substring(l1, 1) + inputWord.Substring(l2, 1) + inputWord.Substring(l3, 1) + " ");
                }
            }
        }
        Console.ReadLine();
    }
    static string InputtingWord()
    {
        bool letterCheck = false;
        bool lengthCheck = false;
        string enteredWord = "  ";
        while (letterCheck == false || lengthCheck == false)
        {
            Console.WriteLine("Enter five letter word: ");
            enteredWord = Console.ReadLine();
            letterCheck = CheckingLetters(enteredWord);
            lengthCheck = CheckingLength(enteredWord);
        }
        return enteredWord;
    }
    static bool CheckingLetters(string checkingWord)
    {
        bool check = true;
        for (int i = 0; i < checkingWord.Length - 1; i++)
        {
            check = char.IsLetter(checkingWord[i]);
            if (check == false)
                Console.WriteLine("Word must consist only letters");
        }
        return check;
    }
    static bool CheckingLength(string chekingWord)
    {
        bool check = true;
        if (chekingWord.Length != 5)
        {
            check = false;
            Console.WriteLine("Entered word must five-letter length");
        }
        return check;
    }
}
