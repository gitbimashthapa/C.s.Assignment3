//using System;

//class Task5Program
//{
//    static void Main()
//    {
//        // For loop: Sum 1 to N
//        Console.Write("Enter a number N: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int sum = 0;

//        for (int i = 1; i <= n; i++)
//            sum += i;
//        Console.WriteLine("Sum = " + sum);

//        // While loop: Print 1–20, skip multiples of 4, stop at 15
//        int num = 1;
//        while (num <= 20)
//        {
//            if (num == 15) break;
//            if (num % 4 == 0)
//            {
//                num++;
//                continue;
//            }
//            Console.WriteLine(num);
//            num++;
//        }

//        // Foreach loop: Sum of array elements
//        int[] arr = { 2, 4, 6, 8 };
//        int total = 0;
//        foreach (int val in arr)
//            total += val;
//        Console.WriteLine("Array Sum = " + total);
//    }
//}
