/*
4.10 (GradeBook Modification) Modify class GradeBook (Fig. 4.12) as follows:
    a) Include a second string auto-implemented property that represents the name of the
    course’s instructor.

    b) Modify the constructor to specify two parameters—one for the course name and one
    for the instructor’s name.

    c) Modify method DisplayMessage such that it first outputs the welcome message and
    course name, then outputs "This course is presented by: ", followed by the instructor’s name.

    Use your modified class in a test app that demonstrates the class’s new capabilities.
*/
using System;

public class GradeBook
{
    public string CourseName { get; set; }

    public string CourseInstructor { get; set; }

    public GradeBook(string name, string instructor)
    {
        CourseName = name;

        CourseInstructor = instructor;
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Welcome to the grade book for\n{0}\n \nThe course is presented by:\n{1}", CourseName, CourseInstructor);
    }
}

