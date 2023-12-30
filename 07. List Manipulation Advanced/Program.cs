namespace _07.List_Manipulation_Advanced
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
            bool hasChanged = false;

            while (command != "end")
            {
                string[] cmdInfo = command.Split();

                if (cmdInfo[0] == "Add")
                {
                    int number = int.Parse(cmdInfo[1]);
                    numbers.Add(number);
                    hasChanged = true;
                }
                else if (cmdInfo[0] == "Remove")
                {
                    int number = int.Parse(cmdInfo[1]);
                    numbers.Remove(number);
                    hasChanged = true;
                }
                else if (cmdInfo[0] == "RemoveAt")
                {
                    int index = int.Parse(cmdInfo[1]);
                    numbers.RemoveAt(index);
                    hasChanged = true;
                }
                else if (cmdInfo[0] == "Insert")
                {
                    int number = int.Parse(cmdInfo[1]);
                    int index = int.Parse(cmdInfo[2]);
                    numbers.Insert(index, number);
                    hasChanged = true;
                }
                else if (cmdInfo[0] == "Contains")
                {
                    int number = int.Parse(cmdInfo[1]);
                    
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (cmdInfo[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (cmdInfo[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (cmdInfo[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (cmdInfo[0] == "Filter")
                {
                    string condition = cmdInfo[1];
                    int number = int.Parse(cmdInfo[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }
                }

                command = Console.ReadLine();
            }

            if (hasChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}