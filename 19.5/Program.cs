/*19.5 (Palindromes) Write a program that uses a stack to determine whether a string is a palindrome (i.e., the string is spelled identically backward and forward).
       The program should ignore capitalization, spaces and punctuation*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._5
{
   
    class Stack
    {

        static char[] stack;
        static int top = -1;

        static void Push(char element)
        {
            stack[++top] = element;
        }

        static char Pop()
        {
            return stack[top--];
        }

        static bool IsPalindrome(char[] str)
        {
            int length = str.Length;

            stack = new char[length * 4];

            int i, mid = length / 2;

            for (i = 0; i < mid; i++)
            {
                Push(str[i]);
            }

            if (length % 2 != 0)
            {
                i++;
            }

            while (i < length)
            {
                char element = Pop();

                if (element != str[i])
                    return false;
                i++;
            }
            return true;
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter string to check:");
            string check = Console.ReadLine();
            int arrayLength = 0;
            

            for (int i = 0; i < check.Length-1; i++)
            {
                if (Char.IsLetterOrDigit(check[i]))
                {
                    arrayLength++;
                }
            }
            char[] arrayCheck = new char[arrayLength];
            for (int i = 0; i < check.Length - 1; i++)
            {
                if (Char.IsLetterOrDigit(check[i]))
                {
                    arrayCheck[i] = Char.ToLower(check[i]);
                }
            }
            

            if (IsPalindrome(arrayCheck) == true)
            {
                Console.Write("String is palindrome");
            }
            else
            {
                Console.Write("String is not palindrome");
            }
            Console.ReadLine();
        }
    }
}

