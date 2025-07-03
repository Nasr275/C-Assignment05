
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

        static void Main(string[] args)
        {

            Program myProgram = new Program();

            #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.


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
            int primeCandidate = int.Parse(Console.ReadLine());
            Console.WriteLine(myProgram.IsPrime(primeCandidate) ? "Prime" : "Not Prime");
            #endregion


            #region 6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters


            #endregion

            #region 7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter


            #endregion



            #region 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter


            #endregion


        }
    }
}










