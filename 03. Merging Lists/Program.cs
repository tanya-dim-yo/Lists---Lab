using System.Dynamic;

namespace _03.Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int minValue = Math.Min(firstNumbers.Count, secondNumbers.Count);

            if (firstNumbers.Count > secondNumbers.Count)
            {
                for (int i = 0; i < secondNumbers.Count; i++)
                {
                    result.Add(firstNumbers[i]);
                    result.Add(secondNumbers[i]);
                }

                for (int i = minValue; i < firstNumbers.Count; i++)
                {
                    result.Add(firstNumbers[i]);
                }
            }
            else
            {
                for (int i = 0; i < firstNumbers.Count; i++)
                {
                    result.Add(firstNumbers[i]);
                    result.Add(secondNumbers[i]);
                }

                for (int i = minValue; i < secondNumbers.Count; i++)
                {
                    result.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}