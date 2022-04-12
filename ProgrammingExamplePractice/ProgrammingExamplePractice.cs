using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExamplePractice
{
    class ProgrammingExamplePractice 
    { 
    //Print number without loop If , Begine and Goto Begine
    public static int PrintNumber()
    {
        int i = 0;
    begine:
        i = i + 1;
        Console.WriteLine(i);
        if (i < 20)
        {
            goto begine;
        }

        return i;
    }
    // Print Star using console.write
    public static void PrintStar2()
    {
        for (int row = 1; row <= 6; ++row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int row = 6; row >= 1; --row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


    }
    //C# program to determine if Two Words Are Anagrams of Each Other
    public static void AnagramsStrings()
    {
        string string1 = "on";
        string strint2 = "no";
        char[] char1 = string1.ToLower().ToCharArray();
        char[] char2 = strint2.ToLower().ToCharArray();
        Console.WriteLine(char1);
        Console.WriteLine(char2);
        Array.Sort(char1);
        Array.Sort(char2);
        Console.WriteLine("After sorting =>");
        Console.WriteLine(char1);
        Console.WriteLine(char2);
        string val1 = new string(char1);
        string val2 = new string(char2);
        if (val1 == val2)
        {
            Console.WriteLine("These two strings are anagram to each other.");
        }
        else
        {
            Console.WriteLine("These two strings are NOT anagram to each other.");
        }
    }
    //c# program for factorial
    public static void CalcFactorialNumber()
    {
        int gnum = 3, newnum = 1;
        for (int i = 1; i <= gnum; i++)
        {
            newnum = (gnum * i);
            //Console.WriteLine("num= "+gnum+" * "+i+"="+newnum);
        }

        Console.WriteLine("Factorial of is = " + newnum);
    }
    //C# program for fibonacci : In case of fibonacci series, next number is the sum of previous two numbers for example 
    public static void FibonacciSeries()
    {
        int num = 1;
        for (int i = 1; i <= 5; i++)
        {
            num = (num + (num - 1));
            Console.WriteLine(num);
        }

    }
    //find the duplicate element in array= IBM question
    public static void FindDupplicateElementInArray()
    {
        int[] originalArray = { 1, 2, 2, 4, 5, 4, 5, 4, 5 };
        int[] newArray = new int[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
        {
            //Console.WriteLine("i for loop", originalArray[i]);
            for (int j = i + 1; j < originalArray.Length; j++)
            {
                //Console.WriteLine("j for loop",originalArray[j]);
                if (originalArray[i] == originalArray[j])
                {
                    Console.WriteLine("original array");
                    Console.WriteLine(originalArray[j]);

                    Console.WriteLine("Newarray");
                    Console.WriteLine(newArray);
                }

            }
            //Console.WriteLine("Duplicate Array Element = ",newArray);
            //Console.WriteLine("Duplicate Array Element = ",newArray);
            /*int[] arr = { 1, 2, 3, 2, 4, 5, 2, 4 };

            var duplicates = arr.GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(y => new { Item = y.Key, Count = y.Count() })
            .ToList();
             Console.WriteLine(String.Join("\n", duplicates));*/

        }
    }
    // Alternate solution on Duplicate Elements
    public static void DuplicateElementinArray()
    {
        int[] arr = { 2, 3, 2, 4, 5, 12, 2, 3, 3, 3, 12 };
        List<int> nums = new List<int>();
        List<int> count = new List<int>();
        nums.Add(arr[0]);
        count.Add(1);
        for (int i = 1; i < arr.Length; i++)
        {

            if (nums.Contains(arr[i]))
            {
                count[nums.IndexOf(arr[i])] += 1;
            }
            else
            {
                nums.Add(arr[i]);
                count.Add(1);
            }
        }

        for (int x = 0; x < nums.Count; x++)
        {
            Console.WriteLine("number:" + nums[x] + "Count :" + count[x]);
        }
        Console.Read();
    }
    //Multiply array elements with 

    //Program for Count of strings without using String Length
    //Program to extract letters from a string Ex123abc123


    //C# program for palindrom
    public static void PalindromString()
    {

        string str1 = "kayak";
        char[] arrStr1 = str1.ToCharArray();
        char[] arrStr2 = str1.ToCharArray();
        Array.Reverse(arrStr1);
            for (int i = 0; i < arrStr1.Length; i++)
            {


                if (arrStr1[i] != arrStr2[i])
                {
                    Console.WriteLine("Word is NOT pallindrom");
                }
                
            }
            Console.WriteLine("Word is palindrom");
        }
}
    //C# program for Prime number
    void FindPrimeno()
    {
        Console.WriteLine();
    }
    //C# program for Armstrong number
    class ExamplePractice
    {
        static void Main(string[] args)
        {

            //1. PrintStar2();
            //2. PrintNumber();
            //3. AnagramsStrings();
            //4. CalcFactorialNumber();
            //5.FibonacciSeries();
            //FibonacciSeries();
            // FindDupplicateElementInArray();
            ProgrammingExamplePractice.PalindromString();


        }
    }
}
