using System;
using Microsoft.VisualBasic.FileIO;

public class lifeSupportRating
{
    public static void Main()
    {
        string filename = @"C:\Users\inmo.yang\source\repos\AdventOfCode\Day3\input.txt";
        var inputArray = File.ReadAllLines(filename);
        var input = new List<string>(inputArray);

        // Get Oxygen Generator rating in binary form
        var oxygenGeneratorList = input;
        int bitPosition = 0;
        while (oxygenGeneratorList.Count > 1)
        {
            // Count number of zero bits and one bits in current list
            var zeroBitCount = ZeroBitCounter(bitPosition, oxygenGeneratorList);
            int oneBitCount = oxygenGeneratorList.Count - zeroBitCount;

            // Only include binary numbers in list where the more common value (0 or 1) is in the current bit position
            oxygenGeneratorList = OxygenGeneratorKeeper(bitPosition, zeroBitCount, oneBitCount, oxygenGeneratorList);

            bitPosition++;
        }
        string oxygenGeneratorRatingBinary = oxygenGeneratorList[0];

        // Get CO2 scrubber rating in binary form
        var CO2ScrubberList = input;
        bitPosition = 0;
        while (CO2ScrubberList.Count > 1)
        {
            // Count number of zero bits and one bits in current list
            var zeroBitCount = ZeroBitCounter(bitPosition, CO2ScrubberList);
            int oneBitCount = CO2ScrubberList.Count - zeroBitCount;

            // Only include binary numbers in list where the less common value (0 or 1) is in the current bit position
            CO2ScrubberList = CO2ScrubberKeeper(bitPosition, zeroBitCount, oneBitCount, CO2ScrubberList);

            bitPosition++;
        }
        string CO2ScrubberRatingBinary = CO2ScrubberList[0];

        // Calculate the life support rating of the ship based on oxygen generator and CO2 Scrubber ratings
        int oxygenGeneratorRating = Convert.ToInt32(oxygenGeneratorRatingBinary, 2);
        int CO2ScrubberRating = Convert.ToInt32(CO2ScrubberRatingBinary, 2);

        int lifeSupportRating = oxygenGeneratorRating * CO2ScrubberRating;
        Console.WriteLine("The life support rating of the submarine is {0}", lifeSupportRating);
    }

    public static List<string> OxygenGeneratorKeeper(int bitPosition, int ZeroBitCount, int OneBitCount, List<string> oxygenGeneratorList)
    {
        if (ZeroBitCount > OneBitCount)
        {
            return oxygenGeneratorList.Where(oxygenGeneratorList => oxygenGeneratorList[bitPosition] == '0').ToList();
        }
        else
        {
            return oxygenGeneratorList.Where(oxygenGeneratorList => oxygenGeneratorList[bitPosition] == '1').ToList();
        }
    }

    public static List<string> CO2ScrubberKeeper(int bitPosition, int ZeroBitCount, int OneBitCount, List<string> CO2ScrubberList)
    {
        if (ZeroBitCount > OneBitCount)
        {
            return CO2ScrubberList.Where(CO2ScrubberList => CO2ScrubberList[bitPosition] == '1').ToList();
        } else
        {
            return CO2ScrubberList.Where(CO2ScrubberList => CO2ScrubberList[bitPosition] == '0').ToList();
        }
    }

    public static int ZeroBitCounter(int bitPosition, List<string> List)
    {
        int countZeros = 0;
        for (int i = 0; i < List.Count; i++)
        {
            if (List[i][bitPosition] == '0')
            {
                countZeros++;
            }
        }
        return countZeros;
    }
}