internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 3, 1, 3, 4, 2 }; // Example input 1
        int repeatingNumber = FindRepeatingNumber(numbers);
        Console.WriteLine("The repeating number is: " + repeatingNumber);


        int[] numbers2 = { 1, 3, 4, 2, 5, 5 }; // Example input 2
        int repeatingNumber2 = FindRepeatingNumber(numbers2);
        Console.WriteLine("The repeating number is: " + repeatingNumber2);


        int[] numbers3 = { 2, 3, 4, 2, 1 }; // Example input 3
        int repeatingNumber3 = FindRepeatingNumber(numbers3);
        Console.WriteLine("The repeating number is: " + repeatingNumber3);


        int[] numbers4 = { 3, 1, 4, 2, 7, 5, 6, 6 }; // Example input 4
        int repeatingNumber4 = FindRepeatingNumber(numbers4);
        Console.WriteLine("The repeating number is: " + repeatingNumber4);
    }

    /// <summary>
    /// The expected sum of numbers from 1 to N can be calculated using the formula: n * (n + 1) / 2.
    /// Calculate the actual sum of all elements in the array.
    /// The difference between the actual sum and the expected sum is the repeated number.
    /// </summary>
    /// <param name="nums">numbers array</param>
    /// <returns>repeating number</returns>
    static int FindRepeatingNumber(int[] nums)
    {
        int n = nums.Length - 1;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        foreach (int num in nums)
        {
            actualSum += num;
        }

        return actualSum - expectedSum;
    }
}
