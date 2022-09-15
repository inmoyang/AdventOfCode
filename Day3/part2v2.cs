//using System;
//using Microsoft.VisualBasic.FileIO;

//public class powerConsumption
//{
//    public static void Main()
//    {
//        string filename = @"C:\Users\inmo.yang\source\repos\AdventOfCode\Day3\input.txt";
//        var inputArray = File.ReadAllLines(filename);
//        var input = new List<string>(inputArray);

//        int numberOfDigits = input[0].Length;
//        int[] countZeros = new int[numberOfDigits];
//        int[] countOnes = new int[numberOfDigits];

//        var oxygenGeneratorList = input;
//        var CO2ScrubberList = input;

//        for (int i = 0; i < numberOfDigits; i++)
//        {
//            for (int j = 0; j < input.Count; j++)
//            {
//                if (input[j][i] == '0')
//                {
//                    countZeros[i]++;
//                }
//                else if (input[j][i] == '1')
//                {
//                    countOnes[i]++;
//                }
//            }

//            // 
//            if (countZeros[i] < countOnes[i])
//            {
//                oxygenGeneratorList = input.Where(input => input[i] == '1').ToList();
//            }
//            else if (countZeros[i] > countOnes[i])
//            {
//                oxygenGeneratorList = input.Where(input => input[i] == '0').ToList();
//            }
//            else
//            {
//                oxygenGeneratorList = input.Where(input => input[i] == '1').ToList();
//            }
//        }

//    }
//}