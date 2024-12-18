using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Drawing;

namespace Assignment_Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            ///Example
            ///Input: 5
            ///Output: 1, 2, 3, 4, 5

            Console.Write("Please Enter a Number : ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            if (isParsed && number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i); // 1, 2, 3, 4, 5

                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            ///Example
            ///Input: 5
            ///Outputs: 5 10 15 20 25 30 35 40 45 50 55 60


            Console.Write("Please Enter a Number : ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            if (isParsed)
            {
                Console.WriteLine($"Multiplication Table for {number}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}"); // 5 10 15 20 25 30 35 40 45 50 55 60
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }


            #endregion

            #region  3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number
            ///Example:
            ///   Input: 15
            ///Output: 2 4 6 8 10 12 14

            Console.Write("Please Enter a Number : ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            if (isParsed && number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i); // 2 4 6 8 10 12 14

                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }

            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            ///    Example:
            ///    Input: 4 3
            /// Output: 64
            /// Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            int firstNumber = 4;
            int secondNumber = 3;
            int result = 1;

            for (int i = 0; i < secondNumber; i++)
            {
                result *= firstNumber;  // 4 ^ 3 = 4 * 4 * 4
            }

            Console.WriteLine($"{firstNumber} power {secondNumber} = {result}"); //64


            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            ///Example
            ///Input: -Enter Marks of five subjects: 95 76 58 90 89
            ///Output: Total marks = 408
            ///Average Marks = 81
            ///Percentage = 81


            int[] marks = { 95, 76, 58, 90, 89 };

            int totalMarks = 0;
            int numberOfSubjects = marks.Length;

            foreach (int item in marks)
            {
                totalMarks += item;  // Calculate total marks 

            }


            int averageMarks = totalMarks / numberOfSubjects; // Calculate average 
            int percentage = (totalMarks * 100) / (numberOfSubjects * 100);  // Calculate percentage

            Console.WriteLine($"Total Marks = {totalMarks}"); //408
            Console.WriteLine($"Average Marks = {averageMarks}"); //81
            Console.WriteLine($"Percentage = {percentage}%"); //81%

            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            Console.Write("Please Enter a string : ");
            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]); // input: Ahmed , Output : demhA
            }


            #endregion

            #region 7 - Write a program to allow the user to enter int and print the REVERSED of it.

          
                Console.Write("Please Enter a Number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        Console.Write(input[i]);  //input:12345 , output:54321
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid Number");
                }


            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            ///Test Data :
            ///Input starting number of ranges: 1
            ///Input ending number of range: 50
            ///Expected Output :
            ///The prime number between 1 and 50 are:
            ///2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            int start = 1;
            int end = 50;

            Console.WriteLine($"Prime numbers between {start} and {end} are:");

            for (int num = start; num <= end; num++)
            {
                if (num <= 1)
                    continue;

                bool isPrime = true;

                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break; 
                    }
                }

                if (isPrime)
                {
                    Console.Write(num + " "); //2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
                }
            }

            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            ///Test Data :
            ///Enter a number to convert: 25
            ///Expected Output :
            ///The Binary of 25 is 11001.

            Console.Write("Enter a number to convert: ");
            int.TryParse(Console.ReadLine(), out int decimalNumber);

            string binaryResult = "";

            while (decimalNumber > 0)
            {

                binaryResult = (decimalNumber % 2) + binaryResult;

                decimalNumber = decimalNumber / 2;
            }

            Console.WriteLine($"The Binary of the number is: {binaryResult}"); //11001


            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.


            Console.WriteLine("Enter coordinates for the first point (x1, y1):");
            int.TryParse(Console.ReadLine(), out int x1);
            int.TryParse(Console.ReadLine(), out int y1);

            Console.WriteLine("Enter coordinates for the second point (x2, y2):");
            int.TryParse(Console.ReadLine(), out int x2);
            int.TryParse(Console.ReadLine(), out int y2);

            Console.WriteLine("Enter coordinates for the third point (x3, y3):");
            int.TryParse(Console.ReadLine(), out int x3);
            int.TryParse(Console.ReadLine(), out int y3);

            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            {
                Console.WriteLine("The points lie on a single straight line");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line");
            }
            #endregion

            #region 11- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            Console.Write("Enter the size of the matrix (n): ");

            bool isParsed = int.TryParse(Console.ReadLine(), out int n);

            if (!isParsed || n <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

            Console.WriteLine($"The identity matrix of size  {n} x {n} is:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");  // Diagonal elements
                    else
                        Console.Write("0 ");  // Non-diagonal elements
                }
                Console.WriteLine();
            }


            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.

            Console.Write("Enter the number of elements in the array: ");

            bool isParsed = int.TryParse(Console.ReadLine(), out int size);

            if (!isParsed || size <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

            int[] numbers = new int[size];

            Console.WriteLine($"Enter {size} elements:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");

                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Please enter a valid integer.");
                    return;
                }
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of all elements in the array is: {sum}");


            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            Console.Write("Enter the number of elements in the arrays: ");
            int.TryParse(Console.ReadLine(), out int size);

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            // Input values for the first array
            Console.WriteLine("Enter the values for the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Input values for the second array
            Console.WriteLine("Enter the values for the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Merge the two arrays
            int[] mergedArray = new int[size * 2];
            for (int i = 0; i < size; i++)
            {
                mergedArray[i] = array1[i];
                mergedArray[size + i] = array2[i];
            }

            // Sort the merged array in ascending order
            Array.Sort(mergedArray);

            // Print the sorted merged array
            Console.WriteLine("The merged and sorted array is:");
            foreach (int item in mergedArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.


            Console.Write("Enter the number of elements in the array: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int size);

            if (!isParsed || size <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }

            int[] array = new int[size];

            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("Frequency of each element in the array:");

            for (int i = 0; i < size; i++)
            {
                bool alreadyCounted = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if (!alreadyCounted)
                {
                    int count = 0;
                    for (int k = 0; k < size; k++)
                    {
                        if (array[i] == array[k])
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"Element {array[i]} occurs {count} time(s)");
                }
            }



            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array

            Console.Write("Enter the number of elements in the array: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int size);
            if (!isParsed || size <= 0)
            {
                Console.WriteLine("Please enter a valid positive Number");
            }

            int[] array = new int[size];

            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Please enter a valid Number");
                }
            }

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < size; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            // Output the maximum and minimum elements
            Console.WriteLine($"The maximum element in the array is: {max}");
            Console.WriteLine($"The minimum element in the array is: {min}");



            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.

            Console.Write("Enter the number of elements in the array: ");

            bool isParsed = int.TryParse(Console.ReadLine(), out int size);
            if (!isParsed || size <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer greater than 1.");
            }

            int[] array = new int[size];

            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Please enter a valid integer.");
                    return;
                }
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;


            for (int i = 0; i < size; i++)
            {
                if (array[i] > largest)
                {
                    secondLargest = largest;
                    largest = array[i];
                }
                else if (array[i] > secondLargest && array[i] != largest)
                {
                    secondLargest = array[i];
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("There is no second largest element. All elements are the same.");
            }
            else
            {
                Console.WriteLine($"The second largest element in the array is: {secondLargest}");
            }

            #endregion

            #region 17-. Consider an Array of Integer values with size N, having values as  in this Example
            ///write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
            ///In the example above, the longest distance is between the first 7 and the
            ///10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            ///And the 10th 7s.

            Console.Write("Enter the number of elements in the array: ");
            int.TryParse(Console.ReadLine(), out int size);

            int[] array = new int[size];

            Console.WriteLine("Enter the values for the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            int maxDistance = -1; 

            for (int i = 0; i < size; i++)
            {
                if (firstOccurrence.ContainsKey(array[i]))
                {
                    int distance = i - firstOccurrence[array[i]] - 1;
                    maxDistance = Math.Max(maxDistance, distance);
                }
                else
                {
                    firstOccurrence[array[i]] = i;
                }
            }

            if (maxDistance >= 0)
            {
                Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            }
            else
            {
                Console.WriteLine("No equal elements found to measure distance.");
            }


            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.

            ///Input: this is a test       Output: test a is this
            //Input: all your base        Output: base your all
            //Input: Word Output: Word
            //Note : 
            //Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement


            Console.Write("Enter a list of space-separated words: ");
            string input = Console.ReadLine();

            // Split the input string
            string[] words = input.Split(' ');

            // Reverse the array 
            Array.Reverse(words);

            string reversed = string.Join(" ", words);
            Console.WriteLine(reversed);


            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            Console.Write("Enter the number of rows: ");
            int.TryParse(Console.ReadLine(), out int rows);

            Console.Write("Enter the number of columns: ");
            int.TryParse(Console.ReadLine(), out int columns);

            int[,] array1 = new int[rows, columns];
            int[,] array2 = new int[rows, columns];


            Console.WriteLine("Enter the values for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2[i, j] = array1[i, j];
                }
            }

            Console.WriteLine("\nThe elements of the second array are:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order

            Console.Write("Enter the number of elements in the array: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int size);
            // Validate input
            if (!isParsed || size <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }

            int[] array = new int[size];

            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }

            Console.WriteLine("The array in reverse order is:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }


            #endregion

        }
    }
}
 


