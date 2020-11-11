using System;

namespace Classes_RectanglesAndCircles
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine($"The area of a circle with {myCircle.Radius} is {myCircle.CalculateArea()}\n" + $" and a perimeter of {myCircle.CalculatePerimeter()}");



            Circle circle2 = new Circle();
            circle2.Radius = 82282828;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();

            Circle circle3 = new Circle(3, 5);


            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 12;
            Console.WriteLine($"The are of a rectangle with {myRectangle.Length} and {myRectangle.Width} is {myRectanle.CalculateArea()}\n");

            Console.ReadKey();
        }
    }
}
