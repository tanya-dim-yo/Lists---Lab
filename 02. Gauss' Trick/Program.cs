namespace _02.Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
                }
            }
            else if (numbers.Count % 2 != 0)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
                }

                result.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}