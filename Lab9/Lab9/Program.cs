using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a wanted shape. 1 for circle, 2 for triangle, 3 for square");
            int shape_switch = int.Parse(Console.ReadLine());
            switch (shape_switch)
            {
                case 1:
                    Circle circle1 = new Circle();
                    Console.WriteLine("Enter radius");
                    circle1.side = int.Parse(Console.ReadLine());
                    circle1.circle_output();
                    break;
                case 2:
                    Triangle triangle1 = new Triangle();
                    triangle1.self_ref = triangle1;
                    Console.WriteLine("Is your triangle ravnostoronii? Y/N");
                    if (Console.ReadLine() == "Y")
                    {
                        triangle1.triangle_space_ravnostoronii();
                    }
                    else
                        Console.WriteLine("Enter first side");

                    Console.WriteLine("Enter second side");

                    Console.WriteLine("Enter third side");
                    Console.ReadLine();
                    break;
                case 3:
                    Square square1 = new Square();
                    Console.WriteLine("Enter side of the square");
                    square1.side = int.Parse(Console.ReadLine());
                    square1.square_output();
                    break;
            }
        }
        class Shape 
        {
            public object self_ref;
            public int side { get; set; }
             
        }
        class Triangle : Shape, ShapeShift
        {
             int side_a { get; set; }
             int side_b { get; set; }
             int side_c { get; set; }
            public void shift()
            {
                Console.WriteLine("Shape shifted for triangle");
                Console.Read();
            }
            public void triangle_space_normal()
            {
                int p = side_a + side_b + side_c;
                int half_p = p / 2;
                double S = Math.Sqrt(half_p * (half_p - side_a) * (half_p - side_b) * (half_p - side_c));
                Console.WriteLine("You entered sides: a={0}, b={1}, c={2}",side_a,side_b,side_c);
                Console.WriteLine("Space of triangle ={0}", S);
                Console.WriteLine("Perimter of triangle={0}", p);
                Console.Read();
                shift();

            }
            public void triangle_space_ravnostoronii()
            {
                Console.WriteLine("Trinagle ravn");
                
                int p = side + side + side;
                int half_p = p / 2;
                double S = Math.Sqrt(half_p * (half_p - side) * (half_p - side) * (half_p - side));
                Console.WriteLine("Space of triangle ={0}", S);
                Console.WriteLine("Perimter of triangle={0}", p);
                Console.Read();
                shift();
            }
        }
        class Circle : Shape
        {
            public void circle_output()
            {
                double pi =3.14;
                Console.WriteLine("Radius entered ={0}",side);
                Console.WriteLine("Space of circle = {0}", Math.Pow(side,2)*pi);
                Console.WriteLine("Perimeter of circle = {0}", side * 2 * pi);
                Console.Read();
            }
        }
        class Square : Shape, ShapeShift
        {

            public void shift()
            {
                Console.WriteLine("Shape shifted for Square");
                Console.Read();
            }
            public void square_output()
            {
                Console.WriteLine("Entered side = {0}",side);
                Console.WriteLine("Space of square = {0}",side * side);
                Console.WriteLine("Perimeter of square = {0}", side * 4);
                Console.Read();
                shift();
                Console.Read();
            }
            
        }
    }
}
