using System;

namespace constructorsToThis 
{
    internal class Program
    {
        static void Main(string[] args)
        {

        int length, width;

           Console.WriteLine("Method that returns a Class :");
           Console.WriteLine("--------------------------------------");

           Console.WriteLine("Input the dimensions of the Square( equal length and Width ):");

           Console.WriteLine("Length: ");
            length = Convert.ToInt32(Console.ReadLine());  
        
           Console.WriteLine("Width: ");  
            width = Convert.ToInt32(Console.ReadLine());
           
           calculation solution = new calculation(length, width);

            int area = solution.getArea();
            int perimeter = solution.getPerimeter();

           Console.WriteLine("Perimeter and Area of the square :");
           Console.WriteLine("Length: " + length);
           Console.WriteLine("Width: " + width);
           Console.WriteLine("Area: " + area);
           Console.WriteLine("Perimeter: " + perimeter);
       

             Console.ReadLine();
  
        }
    }
}
