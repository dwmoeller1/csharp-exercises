using System;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input height
            Console.WriteLine("Enter height:");
            string heightInput = Console.ReadLine();
            //user input width
            Console.WriteLine("Enter width:");
            string widthInput = Console.ReadLine();
            //calculate perimeter
            int perimeter = CalculatePerimeter(heightInput, widthInput);
            //print out perimeter
            Console.WriteLine(perimeter);
            Console.ReadLine();            
        }

        private static int CalculatePerimeter(string heightInput, string widthInput)
        {
            int perimeter =0;
            bool didItWork = int.TryParse(heightInput, out int height);
            int width = int.Parse(widthInput);
            perimeter = 2 * height + 2 * width;
            return perimeter;
        }
    }
}
