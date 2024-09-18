using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the sustained wind speed (in miles per hour):");

        double windSpeed = double.Parse(Console.ReadLine());

        if (windSpeed >= 157)
        {
            Console.WriteLine("Category Five Hurricane");
        }
        else if (windSpeed >= 130)
        {
            Console.WriteLine("Category Four Hurricane");
        }
        else if (windSpeed >= 111)
        {
            Console.WriteLine("Category Three Hurricane");
        }
        else if (windSpeed >= 96)
        {
            Console.WriteLine("Category Two Hurricane");
        }
        else if (windSpeed >= 74)
        {
            Console.WriteLine("Category One Hurricane");
        }
        else
        {
            Console.WriteLine("This is not a hurricane.");
        }
    }
}