using System;
using System.Diagnostics.Contracts;
class Program
{
    static void Main(string[] args)
    {
        string favoriteFood = "Chicken";
        int age = 23;
        bool loveCode = true;
        double gpa = 3.75;
        char initial = 'A';

        Console.WriteLine($"Hi my name starts with {initial}. I'm {age} years old, i love coding: {loveCode}. I love {favoriteFood} and my score is {gpa}");

        DescribePerson("Arthur", 23);

        int sum = AddNumbers(4, 4);
        Console.WriteLine(sum);
        PrintAgeCategory(15);

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        Console.WriteLine($"Counting 1 to {number}");

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);

        }

        while (number >= 1)
        {
            Console.WriteLine(number);
            number--;
        }

        string[] foods = new string[] {"chicken", "beef", "lasagne", "fries"};

        foreach (string food in foods)
        {
            Console.WriteLine(food);
        }

        string[] favFoods = new string[3];

        for (int i = 0; i < favFoods.Length; i++)
        {
            Console.WriteLine($"Enter your  top 3 items # {i}: ");
            favFoods[i] = Console.ReadLine();

        }
        Console.WriteLine("Your favourite food is ");
        foreach (string food in favFoods)
        {
            
            Console.WriteLine(food);
        }
        }
        

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void DescribePerson(string name, int age)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }

    static void PrintAgeCategory(int age)
    {
        if (age >= 18)
        {
            Console.Write("This is an adult");
        }
        else if (age >= 13 && age <= 17)
        {
            Console.Write("This is a teenager");
        }
        else
        {
            Console.Write("This is a child");
        }
    }


}