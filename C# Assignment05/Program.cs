
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment05
{

    internal class Program
    {


        #region 3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        (int, int) SumAndSubtract(int x, int y, int z, int w)
        {
            return (x + y, z - w);
        }
        #endregion

        #region 4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7
        int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        #endregion

        #region 5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) return false;
            return true;
        }
        #endregion

        #region 6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        void MinMaxArray(int[] arr, ref int minVal, ref int maxVal)
        {
            minVal = arr[0];
            maxVal = arr[0];
            foreach (int val in arr)
            {
                if (val < minVal) minVal = val;
                if (val > maxVal) maxVal = val;
            }
        }
        #endregion


        #region 7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
        #endregion

        #region 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        string ChangeChar(string str, int pos, char ch)
        {
            if (pos < 0 || pos >= str.Length)
                return str;
            char[] chars = str.ToCharArray();
            chars[pos] = ch;
            return new string(chars);
        }
        #endregion


        static void Main(string[] args)
        {

            Program myProgram = new Program();

            #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //Value Type Parameters: Pass by Value vs Pass by Reference
            //Includes: int, double, char, bool
            /*
             When we pass value type by value only a copy is passed and 
             the original value in the stack is not affected by any changes made by the method
             */

            /*
             When we pass value type by reference the actual variable is passed.
             Changes made by the method affect the original.
             */

            void PassByValue(int x, int y)
            {
                x += 5;
                y += 5;
            }

            void PassByReference(ref int x, ref int y)
            {
                x += 5;
                y += 5;
            }


            int a = 5, b = 10;
            Console.WriteLine($"Before: a = {a}, b = {b}");
            PassByValue(a, b);
            Console.WriteLine($"After PassByValue: a = {a}, b = {b}");
            PassByReference(ref a, ref b);
            Console.WriteLine($"After PassByReference: a = {a}, b = {b}");



            //Reference Type Parameters: Pass by Value vs Pass by Reference
            //Includes: arrays, strings, objects, lists, etc.

            /*
             When we pass reference types by value, the reference (memory address) is copied.
             This means the method can change the contents of the object, but not reassign it to a new one.
             The original reference in the caller still points to the same object.
             */

            /*
             When we pass reference types by reference using 'ref', the actual reference is passed.
             This allows the method to change the contents of the object and also reassign it to a completely new object.
             The caller will see both content and reference changes.
             */

            void ChangeArrayByValue(int[] arr)
            {
                arr[0] = 100;
                arr = new int[] { 9, 9, 9 };
            }

            void ChangeArrayByRef(ref int[] arr)
            {
                arr = new int[] { 7, 8, 9 };
            }


            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Before change: " + string.Join(",", numbers));
            ChangeArrayByValue(numbers);
            Console.WriteLine("After ChangeArrayByValue: " + string.Join(",", numbers));
            ChangeArrayByRef(ref numbers);
            Console.WriteLine("After ChangeArrayByRef: " + string.Join(",", numbers));



            #endregion

            #region 2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.


            #endregion

            #region Q3 Example

            Console.WriteLine("\nEnter 4 numbers:");
            int.TryParse(Console.ReadLine(), out int n1);
            int.TryParse(Console.ReadLine(), out int n2);
            int.TryParse(Console.ReadLine(), out int n3);
            int.TryParse(Console.ReadLine(), out int n4);

            (int sum, int diff) = myProgram.SumAndSubtract(n1, n2, n3, n4);
            Console.WriteLine($"Sum = {sum}, Difference = {diff}");
            #endregion


            #region Q4 Example
            Console.Write("\nEnter a number: ");
            int.TryParse(Console.ReadLine(), out int number);
            int digitSum = myProgram.SumOfDigits(number);
            Console.WriteLine($"The sum of the digits of the number {number} is: {digitSum}");
            #endregion


            #region Q5 Example
            Console.Write("\nEnter a number to check if it's prime: ");
            int.TryParse(Console.ReadLine(), out int primeCandidate);
            Console.WriteLine(myProgram.IsPrime(primeCandidate) ? "Prime" : "Not Prime");
            #endregion


            #region Q6 Example

            int[] sampleArray = { 5, 8, 2, 9, 1, 7 };
            int min = 0, max = 0;
            myProgram.MinMaxArray(sampleArray, ref min, ref max);
            Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion

            #region Q7 Example

            Console.Write("\nEnter number to calculate factorial: ");
            int.TryParse(Console.ReadLine(), out int factNum);
            Console.WriteLine($"Factorial of {factNum} is {myProgram.Factorial(factNum)}");

            #endregion



            #region Q8 Example

            Console.Write("\nEnter a string: ");
            string original = Console.ReadLine();
            Console.Write("Enter index to replace: ");
            int.TryParse(Console.ReadLine(), out int index);
            Console.Write("Enter new character: ");
            char.TryParse(Console.ReadLine(), out char newChar);

            string modified = myProgram.ChangeChar(original, index, newChar);
            Console.WriteLine($"Modified string: {modified}");

            #endregion


        }
    }
}










