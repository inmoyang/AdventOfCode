// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.VisualBasic.FileIO;

public class CalculateMultipleOfFinalaimAndHorizontalPosition
{
    public static void Main()
    {
        string filename = @"C:\Users\inmo.yang\source\repos\AdventOfCode\Day2\input.txt";

        using (TextFieldParser parser = new TextFieldParser(filename))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(" ");

            int horizontalPosition = 0;
            int aim = 0;
            int depth = 0;

            int i = 0;
            while (!parser.EndOfData)
            {
                //Processing row
                string[] fields = parser.ReadFields();

                string directions = fields[0];
                int units = Int16.Parse(fields[1]);

                if (directions == "down"){
                    aim += units; 
                }else if (directions == "up"){
                    aim -= units;
                }else if(directions == "forward"){
                    horizontalPosition += units;
                    depth += units * aim;
                }

                i++;
            }

            Console.WriteLine(horizontalPosition*depth);
        }

    }
}
