namespace _06.List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdInfo = command.Split();

                if (cmdInfo[0] == "Add")
                {
                    int number = int.Parse(cmdInfo[1]);
                    numbers.Add(number);
                }
                else if (cmdInfo[0] == "Remove")
                {
                    int number = int.Parse(cmdInfo[1]);
                    numbers.Remove(number);
                }
                else if (cmdInfo[0] == "RemoveAt")
                {
                    int index = int.Parse(cmdInfo[1]);
                    numbers.RemoveAt(index);
                }
                else if (cmdInfo[0] == "Insert")
                {
                    int number = int.Parse(cmdInfo[1]);
                    int index = int.Parse(cmdInfo[2]);
                    numbers.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}