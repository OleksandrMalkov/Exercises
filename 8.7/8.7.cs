/*  8.7 Determine whether each of the following is true or false. If false, explain why.
        a) To refer to a particular location or element within an array, we specify the name of the array’s variable and the value of the particular element.
        b) The declaration of a variable that references an array reserves memory for the array.
        c) To indicate that 100 locations should be reserved for integer array p, the programmer writes the declaration p[ 100 ];
        d) An app that initializes the elements of a 15-element array to 0 must contain at least one for statement.
        e) To total the elements of a two-dimensional array you must use nested for statements.

Answers:

a) False. To refer to a particular location or element within an array, we specify the the name of the array, followed by the index of the particular element in square brackets ([]).
b) False. The reference type of data doesn`t reserve memory for anyting, except reference.
c) False. The declaration and array-creation expression should look like this: int[] p = new int[ 100 ];
d) False. If you create an array that consists of numeric simple-type elements each element of the array receives a default value — 0.
e) False. You can use nested for statements or foreach statement.
*/ 