using System;

/// <summary>
/// Tuan - TEST BackEnd DEV
/// </summary>
class RecursiveSolution
{
    /// <summary>
    /// Arrange Recursive Function
    /// </summary>
    /// <param name="inputArray"></param>
    /// <param name="outputArray"></param>
    /// <param name="i"> i for saving odd index </param>
    /// <param name="j"> j for saving even index </param>
    /// <returns></returns>
    public static int[] Arrange(int[] inputArray, int[] outputArray, int i, int j)
    {
        // get odd index in first half of output array
        // outputArray[j] is first half of output array
        // inputArray[i] is odd index
        outputArray[j] = inputArray[i];

        // get even index in second half of output array
        // outputArray[j + inputArray.Count() / 2] is second half of output array
        // inputArray[i+1] is even index
        outputArray[j + inputArray.Count() / 2] = inputArray[i + 1];

        // stopping condition recursive function
        if (i < inputArray.Count() - 2)
        {
            return Arrange(inputArray, outputArray, i + 2, j + 1);
        }
        else
        {
            return outputArray;
        }
    }

    public static void Main(String[] args)
    {
        // input array
        String[] inputArrayString = Console.ReadLine().Split(' ');

        // get array size
        int arraySize = inputArrayString.Count();


        // convert string array to int array
        int[] inputArray = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            inputArray[i] = Int32.Parse(inputArrayString[i]);
        }

        // init result array and solve problem
        int[] outputArray = new int[arraySize];
        outputArray = Arrange(inputArray, outputArray, 0, 0);

        // print result array
        for (int i = 0; i < arraySize; ++i)
            Console.Write(outputArray[i] + " ");
    }
}

