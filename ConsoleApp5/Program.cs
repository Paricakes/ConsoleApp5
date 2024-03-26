using System;
using System.Collections.Generic;

namespace PersonWeightTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.WriteLine("Welcome to Person Weight Tracker!");

            // Loop to add persons
            while (true)
            {
                Console.WriteLine("Enter the person's name (or type 'done' to finish adding persons):");
                string name = Console.ReadLine();

                if (name.ToLower() == "done")
                    break;

                Console.WriteLine("Enter the person's weight:");
                if (int.TryParse(Console.ReadLine(), out int weight))
                {
                    Person person = new Person(name, weight);
                    persons.Add(person);
                    Console.WriteLine("Person added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid input for weight. Please enter a valid integer.");
                }
            }

            // Display all names
            Console.WriteLine("\nList of Persons:");
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }

            // Calculate total weight
            int totalWeight = 0;
            foreach (var person in persons)
            {
                totalWeight += person.Weight;
            }
            Console.WriteLine($"\nTotal weight of all persons: {totalWeight}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Person(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }