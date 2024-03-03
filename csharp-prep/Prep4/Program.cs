using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, (type 0 when finished entering numbers).");

        int userInput;

        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        } while (userInput != 0);

        if (numbers.Count > 0)
        {

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }


            double average = (double)sum / numbers.Count;


            int maxNumber = numbers[0];
            foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}