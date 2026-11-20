using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // DSA Activity 8.1 - Rubi, Vince Paul Ronald
        Dictionary<string, string> records = new Dictionary<string, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nRECORD KEEPING PROGRAM");
            Console.WriteLine("[1] Add Data");
            Console.WriteLine("[2] Delete Data");
            Console.WriteLine("[3] Display Data");
            Console.WriteLine("[4] End");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Key: ");
                string key = Console.ReadLine();
                Console.Write("Enter Value: ");
                string value = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(key))
                {
                    Console.WriteLine("Key cannot be empty!");
                }
                else if (records.ContainsKey(key))
                {
                    Console.WriteLine("The key already exists!");
                }
                else
                {
                    records.Add(key, value);
                    Console.WriteLine("Data successfully added!");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Enter Key to delete: ");
                string key = Console.ReadLine();

                if (records.Remove(key))
                    Console.WriteLine("Data successfully deleted!");
                else
                    Console.WriteLine("The key does not exist!");
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nRECORDS:");
                if (records.Count == 0)
                {
                    Console.WriteLine("No data to display.");
                }
                else
                {
                    foreach (KeyValuePair<string, string> item in records)
                    {
                        Console.WriteLine("Key: " + item.Key + " | Value: " + item.Value);
                    }
                }
            }
            else if (choice == "4")
            {
                running = false;
                Console.WriteLine("Thank you.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 to 4.");
            }
        }
    }
}