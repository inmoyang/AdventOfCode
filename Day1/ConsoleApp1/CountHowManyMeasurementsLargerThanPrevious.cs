// See https://aka.ms/new-console-template for more information
using System;

public class CountHowManyMeasurementsLargerThanPrevious
{
    public static void Main()
    {
        string filename = @"C:\Users\inmo.yang\source\repos\AdventOfCode\Day1\input.txt";
        var measurements = File.ReadAllLines(filename);

        int count = 0;
        int sum1;
        int sum2;

        for (int i = 0; i < measurements.Length-3; i++)
        {
            sum1 = 0;
            sum2 = 0;
            for (int j = 0; j <=2; j++)
            {
                sum1 += Int16.Parse(measurements[i + j]);
                sum2 += Int16.Parse(measurements[i + j + 1]);
            }
            if (sum1 < sum2)
            {
                count += 1;
            }
        }
        Console.WriteLine(count);
    }
}
