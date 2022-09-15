//using System;
//using Microsoft.VisualBasic.FileIO;



///* MAYBE START AGAIN. TWO PROBLEMS I CAN SEE. 
//1. arrayOfBinaryNumbersThatHave0InPositioni and arrayOfBinaryNumbersThatHave1InPositioni still have the old binary numbers with indexes that exceed getLengthNotIncludingNulls(input)
//2. 
//*/

//public class powerConsumption
//{
//    public static void Main()
//    {
//        string filename = @"C:\Users\inmo.yang\source\repos\AdventOfCode\Day3\input.txt";
//        var input = File.ReadAllLines(filename);

//        int numberOfDigits = input[0].Length;
//        int[] countZeros = new int[numberOfDigits];
//        int[] countOnes = new int[numberOfDigits];
//        string[] arrayOfBinaryNumbersThatHave0InPositioni = new string[input.Length];
//        string[] arrayOfBinaryNumbersThatHave1InPositioni = new string[input.Length];
//        int jIndexOfBinaryNumbersThatHave0InPositioni = 0;
//        int jIndexOfBinaryNumbersThatHave1InPositioni = 0;

//        // Number of digits in each binary number
//        for (int i = 0; i < numberOfDigits; i++)
//        {
//            // Number of binary numbers
//            for (int j = 0; j < input.Length; j++)
//            {
//                if (input[j][i] == '0')
//                {
//                    countZeros[i]++;
//                    // Store all binary numbers that have 0 in position i
//                    arrayOfBinaryNumbersThatHave0InPositioni[jIndexOfBinaryNumbersThatHave0InPositioni] = input[j];
//                    jIndexOfBinaryNumbersThatHave0InPositioni++;
//                }
//                else if (input[j][i] == '1')
//                {
//                    countOnes[i]++;
//                    // Store all binary numbers that have 1 in position i
//                    arrayOfBinaryNumbersThatHave1InPositioni[jIndexOfBinaryNumbersThatHave1InPositioni] = input[j];
//                    jIndexOfBinaryNumbersThatHave1InPositioni++;
//                }
//            }
//            /* Part 2 Code */

//            // Overwrite input with arrays only with 0s or 1s in position i based on which is more common
//            // if zeros and ones are equally common in position i, overwrite with array of binary numbers that have 0s in position i


//            if (countZeros[i] < countOnes[i])
//            {
//                Array.Resize(ref input, countOnes[i]);
//                Console.WriteLine(input.Length);
//                input = arrayOfBinaryNumbersThatHave1InPositioni;
//            }
//            else
//            {
//                Array.Resize(ref input, countZeros[i]);
//                input = arrayOfBinaryNumbersThatHave0InPositioni;
//            }
//            jIndexOfBinaryNumbersThatHave0InPositioni = 0;
//            jIndexOfBinaryNumbersThatHave1InPositioni = 0;
//        }
//    }

//    public static int getLengthNotIncludingNulls(string[] array)
//    {
//        int count = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] != null)
//            {
//                count++;
//            }
//        }
//        return count;
//    }
//}