/*11.5 (Shape Inheritance Hierarchy) The world of shapes is much richer than the shapes included in the inheritance hierarchy of Fig. 11.3. 
       Write down all the shapes you can think of—both twodimensional and three-dimensional—and form them into a more complete Shape hierarchy with as
       many levels as possible. Your hierarchy should have class Shape at the top. Class TwoDimensionalShape and class ThreeDimensionalShape should extend Shape. 
       Add additional derived classes, such as Quadrilateral and Sphere, at their correct locations in the hierarchy as necessary.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Shape
{
}

class TwoDimensional : Shape
{
}

class ThreeDimensional : Shape
{
}

class Circle : TwoDimensional
{
}
class Oval : Circle
{
}

class Rectangle : TwoDimensional
{
}
class Square : Rectangle
{
}

class Triangle : TwoDimensional
{
}

class Rhombus : Rectangle
{
}

class Trapezium : TwoDimensional
{
}

class Pentagon : TwoDimensional
{
}

class Hexagon: TwoDimensional
{
}

class Pentagram : TwoDimensional
{
}

class Prism: ThreeDimensional
{
}

class Cone:ThreeDimensional
{
}

class Pyramid : ThreeDimensional
{
}

class Cube : ThreeDimensional
{
}

class Cylinder: ThreeDimensional
{
}
