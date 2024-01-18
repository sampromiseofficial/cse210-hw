using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int sum = 0;

        Console.Write("Enter a list of numbers or (0 to stop): ");
        string userList = Console.ReadLine();

        while (int.TryParse(userList, out int listNumber) && listNumber != 0)
        {
            numbers.Add(listNumber);

            Console.Write("Enter another number or (0 to stop): ");
            userList = Console.ReadLine();
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Count > 0 ? numbers[0] : 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}