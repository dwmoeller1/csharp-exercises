using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int radiusInput = GetRadiusInput();
            double area = CalculateArea(radiusInput);
            ReturnArea(area);
        }

        private static void ReturnArea(double area)
        {
            Console.WriteLine($"The area is: {area}");
        }

        private static double CalculateArea(int radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 3);
        }

        private static int GetRadiusInput()
        {
            int radius;
            Console.WriteLine("Enter radius:");
            while (!ValidateInput(Console.ReadLine(), out radius){
                Console.WriteLine("Please enter a integer.");
                Console.WriteLine("Enter radius:");
            }
            return radius;
        }

        private static bool ValidateInput(string input, out int output)
        {
            return int.TryParse(input, out output);
        }
    }
}
