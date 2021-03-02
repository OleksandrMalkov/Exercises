using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* a) False.  C# applies the operators in arithmetic expressions in a precise sequence determined by the following rules of operator precedence:
             *    - Operators in the innermost set of parentheses is evaluated first.
             *    - After *, /, % evaluated next, + and - evaluated after them.
             *    - If there are several operators of same type of precedence, they’re evaluated from left to right. 
             *    - Some operators, such as assignment, =, associate from right to left rather than left to right.
             *    
             * b) True
             * 
             * c) False. If there are several operators of same type of precedence, they’re evaluated from left to right. 
             *    Also, some operators, such as assignment, associate from right to left rather than left to right.
             *    
             * d) False. h22 is valid variable identificator.*/
        }
    }
}
