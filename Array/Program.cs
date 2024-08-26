using System;

namespace ARRAY;

class Program
{
    public static void Main()
    {
        int flag = 0;
        Console.WriteLine("Enter the size of the array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] array = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"enter the value of {i} : ");
            string temp = Console.ReadLine();
            array[i] = temp;
        }

        Console.WriteLine("-----------------------Printing the elements in the array :---------------------------");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"elements present at {i} position : {array[i]}");
        }
        Console.WriteLine("---------------SEARCHING-------------------");
        Console.WriteLine("Enter any name to search : ");
        string search_name = Console.ReadLine();

        for (int i = 0; i < n; i++)
        {
            if (search_name == array[i])
            {
                flag = 1;
                Console.WriteLine($"{array[i]} is present at the index {i}");
            }
        }
        if (flag == 0)
        {
            Console.WriteLine($"The given name {search_name} is not present in the array");
        }

        Console.WriteLine("--------------------------------------------Now using foreach loop----------------------------------------------");

        foreach (var name in array)
        {
            if (search_name == name)
            {
                Console.WriteLine($"{name} is present in the array");
                flag = 1;
                break;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine($"The given name {search_name} is not present in the array");
        }

    }
}