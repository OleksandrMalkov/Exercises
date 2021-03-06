using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Class1
{
    public static void Main(string[] args)
    {
        GradeBook gradeBook1 = new GradeBook("CS101 Introduction to C# Programming!", "Sylvester Stallone");
        GradeBook gradeBook2 = new GradeBook("CS102 Introduction to C# Programming!", "Ralph Bohner");
      
        gradeBook1.DisplayMessage();
        Console.WriteLine();
        Console.WriteLine();
        gradeBook2.DisplayMessage();

        Console.ReadLine();
    }
}






