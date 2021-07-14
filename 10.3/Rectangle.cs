/* 10.3 (Rectangle Class) Create class Rectangle. The class has attributes length and width, each of which defaults to 1.
        It has read-only properties that calculate the Perimeter and the Area of the rectangle. It has properties for both length and width.
        The set accessors should verify that length and width are each floating-point numbers greater than 0.0 and less than 20.0. Write an app to test class Rectangle.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Rectangle
{
    private double length;
    private double width;

    public double Length
    {
        get
        {
            return length;
        }
        set
        {
            if (value <= 0.0 || value >= 20.0)
                throw new ArgumentOutOfRangeException();
            else
                length = value;
        }
    }
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value <= 0.0 || value >= 20.0)
                throw new ArgumentOutOfRangeException();
            else
                width = value;
        }
    }
    public double Perimeter
    {
        get
        {
            return (Length + Width) * 2;
        }
    }
    public double Area
    {
        get
        {
            return Length * Width;
        }
    }
    public Rectangle(double length = 1, double width = 1)
    {
        Length = length;
        Width = width;
    }
}
