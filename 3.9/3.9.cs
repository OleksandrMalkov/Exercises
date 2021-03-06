/*3.9 State whether each of the following is true or false. If false, explain why.
    a) C# operators are evaluated from left to right.
    b) The following are all valid variable names: _under_bar_, m928134, t5, j7, her_sales,
      his_account_total, a, b, c, z and z2.
    c) A valid C# arithmetic expression with no parentheses is evaluated from left to right.
    d) The following are all invalid variable names: 3g, 87, 67h2, h22 and 2h.

Answers:

    a) False.  C# applies the operators in arithmetic expressions in a precise sequence determined by the following rules of operator precedence:
           - Operators in the innermost set of parentheses is evaluated first.
           - After *, /, % evaluated next, + and - evaluated after them.
           - If there are several operators of same type of precedence, they’re evaluated from left to right. 
           - Some operators, such as assignment, =, associate from right to left rather than left to right.
              
    b) True
    c) False. If there are several operators of same type of precedence, they’re evaluated from left to right. 
       Also, some operators, such as assignment, associate from right to left rather than left to right.
    d) False. h22 is valid variable identificator.
*/
        