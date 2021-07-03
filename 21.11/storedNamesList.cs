/*21.11 (LinkedList without Duplicates) Write an app that reads in a series of first names and stores them in a LinkedList. Do not store duplicate names. Allow the user to search for a first name.*/
using System;
using System.Collections.Generic;

namespace _21._11
{
    class storedNamesList
    {
        private LinkedList<string> storedNames;

        public storedNamesList()
        {
            storedNames = new LinkedList<string>();

            EnterName();
            FindName();
        }
        public void EnterName()
        {
            string enteredName;
            do
            {
                Console.WriteLine("Enter Name for adding or -1 to end: ");
                enteredName = Console.ReadLine();
                if (enteredName == "-1")
                {
                    return;
                }
                if (storedNames.Find(enteredName) == null)
                {
                    storedNames.AddLast(enteredName);
                    Console.WriteLine("Name added!");
                }
                else
                    Console.WriteLine(enteredName + " already exists in list");
            } while (enteredName != null);
        }

        public void FindName()
        {

            string inputName;
            do
            {
                Console.WriteLine("Enter Name for searching or -1 to end: ");
                inputName = Console.ReadLine();
                if (inputName == "-1")
                {
                    return;
                }
                if (storedNames.Find(inputName) == null)
                {
                    Console.WriteLine(inputName + " not found in list");
                }
                else
                {
                    Console.WriteLine(inputName + " found in list");
                }
            } while (inputName != null);
        }
    }
}
