using System;
namespace Assignment_1
{
    internal class Assignment_transaction
    {
        float current_balance = 0;

        public void  PerformTransactions()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Please choose:");
                Console.WriteLine("d for deposit\nc for checking balance\nw for withdraw");

                char option = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (option)
                {
                    case 'd':
                        float deposit;
                        Console.WriteLine("Please enter the amount you want to deposit");
                        if (float.TryParse(Console.ReadLine(), out deposit))
                        {
                            current_balance += deposit; // Update the current balance
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                        }
                        break;

                    case 'c':
                        if (current_balance != 0)
                        {
                            Console.WriteLine("Current balance: " + current_balance);
                        }
                        else
                        {
                            Console.WriteLine("Current balance is 0 ");
                        }
                        
                        break;

                    case 'w':
                        float withdraw;
                        Console.WriteLine("Please enter the amount you want to withdraw");
                        if (float.TryParse(Console.ReadLine(), out withdraw))
                        {   if (current_balance > withdraw)
                            {
                                current_balance -= withdraw; // Update the current balance
                            }
                            else
                            {
                                Console.WriteLine("You have insufficient balance");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
            Console.WriteLine("Your balance is:" + current_balance);
        }
    }
   
}
