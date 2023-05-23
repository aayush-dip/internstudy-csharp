using System;

public class AgeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your date of birth (dd mm yyyy):");

        string dd = Console.ReadLine();
        string mm = Console.ReadLine();
        string yyyy = Console.ReadLine();

        if (DateTime.TryParse($"{mm}/{dd}/{yyyy}", out DateTime dateOfBirth))
        {
            DateTime currentDate = DateTime.Now;

            if (dateOfBirth > currentDate)
            {
                Console.WriteLine("Invalid date! It's a future date.");
            }
            else
            {
                TimeSpan age = currentDate - dateOfBirth;

                if (age.TotalDays < 1)
                {
                    Console.WriteLine("Invalid date! Age must be at least 1 day.");
                }
                else
                {
                    int years = (int)(age.TotalDays / 365);
                    int months = (int)((age.TotalDays % 365) / 30);
                    int days = (int)((age.TotalDays % 365) % 30);

                    Console.WriteLine($"You are {days} day/s old.");
                    Console.WriteLine($"You are {months} month/s old.");
                    Console.WriteLine($"You are {years} year/s old.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid date format!");
        }
    }
}
