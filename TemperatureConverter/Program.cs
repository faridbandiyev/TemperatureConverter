﻿namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
        repeat:
            Console.WriteLine("Type the temperature (in celcius): ");
            string inputCelcius = Console.ReadLine();
            int celcius;
            if (int.TryParse(inputCelcius, out celcius))
            {
                Console.WriteLine($"Fahrenheit: {celcius * 1.8f + 32}");
            }

            else
            {
                Console.WriteLine("Error!");
            }
            goto repeat;
        }
    }
}
