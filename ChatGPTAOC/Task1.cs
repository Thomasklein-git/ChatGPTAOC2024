using System.Text.RegularExpressions;

namespace ChatGPTAOC
{
   public static class Task1
   {
      public static void SolveTask1(string inputFile)
      {
         // Read input from the file
         string[] input = File.ReadAllLines(inputFile);

         // Initialize lists to store numbers
         List<int> leftList = new List<int>();
         List<int> rightList = new List<int>();

         // Parse the input and populate the lists
         foreach (var line in input)
         {
            // Use regex to split by any whitespace (spaces, tabs, etc.)
            var numbers = Regex.Split(line.Trim(), @"\s+").Select(int.Parse).ToArray();
            leftList.Add(numbers[0]);
            rightList.Add(numbers[1]);
         }

         // Sort both lists
         leftList.Sort();
         rightList.Sort();

         // Calculate the total distance
         int totalDistance = 0;
         for (int i = 0; i < leftList.Count; i++)
         {
            totalDistance += Math.Abs(leftList[i] - rightList[i]);
         }

         // Output the total distance
         Console.WriteLine("Total distance: " + totalDistance);
      }
      public static void SolveTask2(string inputFile)
      {
         // Read input from the file
         string[] input = File.ReadAllLines(inputFile);

         // Initialize lists to store numbers
         List<int> leftList = new List<int>();
         List<int> rightList = new List<int>();

         // Parse the input and populate the lists
         foreach (var line in input)
         {
            // Use regex to split by any whitespace (spaces, tabs, etc.)
            var numbers = Regex.Split(line.Trim(), @"\s+").Select(int.Parse).ToArray();
            leftList.Add(numbers[0]);
            rightList.Add(numbers[1]);
         }

         // Calculate the similarity score
         int similarityScore = 0;
         foreach (var num in leftList)
         {
            // Count how many times 'num' appears in the right list
            int countInRightList = rightList.Count(x => x == num);

            // Add to the similarity score the product of the number and its count in the right list
            similarityScore += num * countInRightList;
         }

         // Output the total similarity score
         Console.WriteLine("Total similarity score: " + similarityScore);
      }
   }
}
