using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._4
{

    // class to represent one node in a stack
    class StackNode
    {
        // automatic read-only property Data
        public object Data { get; private set; }

        // automatic property Next
        public StackNode Next { get; set; }

        // constructor to create StackNode that refers to dataValue
        // and is last node in Stack
        public StackNode(object dataValue) : this(dataValue, null) { }

        // constructor to create StackNode that refers to dataValue
        // and refers to next StackNode in Stack
        public StackNode(object dataValue, StackNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
    public class Stack
    {
        private StackNode firstNode;
        private StackNode lastNode;
        private string name; 

        // construct empty stack with specified name
        public Stack(string stackName)
        {
            name = stackName;
            firstNode = lastNode = null;
        }

        // construct empty stack with "stack" as its name 
        public Stack() : this("stack") { }

        // Insert object at front of Stack. If Stack is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, firstNode refers to new node.
        public void Push(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new StackNode(insertItem);
            }
            else
            {
                firstNode = new StackNode(insertItem, firstNode);
            }
        }

        // remove first node from Stack
        public object Pop()
        {
            if (IsEmpty())
            {
                throw new EmptyStackException(name);
            }

            object removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }


        // return true if Stack is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output Stack contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                StackNode current = firstNode;

                // output current node data while not at end of stack
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
    }

    // class EmptyStackException declaration
    public class EmptyStackException : Exception
    {
        // parameterless constructor
        public EmptyStackException() : base("The stack is empty") { }

        // one-parameter constructor
        public EmptyStackException(string name)
           : base($"The {name} is empty") { }

        // two-parameter constructor
        public EmptyStackException(string exception, Exception inner)
           : base(exception, inner) { }
    }
}

