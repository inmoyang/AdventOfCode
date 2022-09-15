//using System;
//using Microsoft.VisualBasic.FileIO;

//public class powerConsumption
//{
//    public static void Main()
//    {
//        string filename = @"C:\Users\inmo.yang\source\repos\AdventOfCode\Day3\input.txt";
//        var input = File.ReadAllLines(filename);

//        int numberOfDigits = input[0].Length;
//        int[] countZeros = new int[numberOfDigits];
//        int[] countOnes = new int[numberOfDigits];
//        string[] gammaRateBin = new string[numberOfDigits];
//        string[] epsilonRateBin = new string[numberOfDigits];


//        for (int i = 0; i < input.Length; i++)
//        {
//            for (int j = 0; j < numberOfDigits; j++)
//            {
//                if (input[i][j] == '0')
//                {
//                    countZeros[j]++;
//                }
//                else
//                {
//                    countOnes[j]++;
//                }
//            }
//        }

//        for (int i = 0; i < numberOfDigits; i++)
//        {
//            if (countZeros[i] > countOnes[i])
//            {
//                gammaRateBin[i] = "1";
//                epsilonRateBin[i] = "0";
//            }
//            else
//            {
//                gammaRateBin[i] = "0";
//                epsilonRateBin[i] = "1";
//            }
//        }

//        string gammaRateStringBin = String.Join("",gammaRateBin);
//        string epsilonRateStringBin = String.Join("", epsilonRateBin);

//        int gammaRate = Convert.ToInt32(gammaRateStringBin,2);
//        int epsilonRate = Convert.ToInt32(epsilonRateStringBin,2);

//        Console.WriteLine("The power consumption of the submarine is: {0}",gammaRate*epsilonRate);
//    }
//}