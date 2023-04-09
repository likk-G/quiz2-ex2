// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;

Console.Write("Enter Length Of First Array:");
int length1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Length Of Second Array:");
int length2 = Convert.ToInt32(Console.ReadLine());

if (length1 != length2)
{
    Console.WriteLine("Arrays Don't Match");
}

else
{

    int[] arr1 = new int[length1];
    int[] arr2 = new int[length1];

    Console.Write("Enter First Array: ");
    for (int i = 0; i < length1; i++)
    {
        arr1[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Enter Second Array: ");
    for (int i = 0; i < length1; i++)
    {
        arr2[i] = Convert.ToInt32(Console.ReadLine());
    }

    Array.Sort(arr1);
    Array.Sort(arr2);
    int check = 0;

    for (int i = 0; i < length1; i++)
    {
        if (arr1[i] != arr2[i])
        {
            check++;
        }
    }

    if (check == 0)
    {
        Console.WriteLine("Arrays Match");
    }
    else
    {
        Console.WriteLine("Arrays Don't Match");
    }
}