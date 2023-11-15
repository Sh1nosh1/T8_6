using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace T8_6
{
    internal class Program
    {
        //Task 1
        //The array is designed to store the height values of twelve people. Using a random number probe,
        //fill the array with integer values lying in the range from 163 to 190 inclusive.
        //Output the values of the elements using a for loop. Find the average height.

        /*public static int[] InputHeight()
        {
            int[] heights = new int[12];
            Random random = new Random();

            for(int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(163, 190);
            }

            return heights;
        }

        public static void OutputHeights(int[] heights)
        {
            WriteLine("The height of each of the 12 people: \n");

            for(int i = 0; i < heights.Length; i++)
            {
                Write($"{heights[i]};\t");
            }
        }

        public static int Average(int[] heights)
        {
            int sum = 0;

            foreach(int element in heights)
            {
                sum += element;
            }

            return sum / heights.Length;
        }*/


        //Task 2
        //Fill an array of eight elements with the following values using explicit initialization: the first element of the array is 37,
        //the second is 0, the third is 50, the fourth is 46, the fifth is 34, the sixth is 46, the seventh is 0, and the eighth is -13.
        //Find the maximum and minimum elements of the array.

        /*public static int[] InputElements()
        {
            int[] elements = { 37, 0, 50, 46, 34, 46, 0, -13 };

            return elements;
        }
        
        public static void OutputElements(int[] elements)
        {
            WriteLine("The elements of array:\n");

            for (int i = 0; i < elements.Length; i++)
            {
                Write($"{elements[i]};\t");
            }
        }

        public static int Maximum(int[] elements)
        {
            int max = 0;

            foreach (int element in elements)
            {
                if(element > max)
                {
                    max = element;
                }
            }

            return max;
        }

        public static int Minimum(int[] elements)
        {
            int min = 0;

            foreach (int element in elements)
            {
                if (element < min)
                {
                    min = element;
                }
            }

            return min;
        }*/


        //Task 3
        //Fill a one-dimensional array from the keyboard and display the array elements on the screen in reverse order.

        /*public static int[] InputArray()
        {
            Write("Enter the array dimension: ");
            byte n = Convert.ToByte(ReadLine());
            int[] array = new int[n];
            WriteLine();

            for (byte i = 0; i < array.Length; i++)
            {
                Write($"The {i+1} element = ");
                array[i] = Convert.ToInt32(ReadLine());
            }

            return array;
        }

        public static void OutputArrayReverse(int[] array)
        {
            WriteLine("\n\nReverse array: \n");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Write($"The {i+1} element = {array[i]}\n");
            }
        }*/


        //Task 4
        //Fill a one-dimensional array randomly from -5 to 5 with integers. Increase all elements by a factor of two.
        //Output the new array values using a foreach cycle.

        /*public static int[] InputArray()
        {
            Write("Enter the array dimension: ");
            byte n = Convert.ToByte(ReadLine());

            int[] array = new int[n];
            Random random = new Random();

            WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 5);
                Write($"{array[i]};\t");
            }

            return array;
        }

        public static void OutputArrayx2(int[] array)
        {
            WriteLine("\n\nDoubled array elements: \n");
            foreach(int element in array)
            {
                Write($"{element*2};\t");
            }
        }*/


        //Task 5
        //The array contains information about grades of 25 students in chemistry. Determine the number of pupils failing in chemistry.

        public static int[] InputGrades()
        {
            int[] grades = new int[25];
            Random random = new Random();

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = random.Next(2, 5);
            }

            return grades;
        }

        public static void OutputGrades(int[] grades)
        {
            foreach (int element in grades)
            {
                Write($"{element};\t");
            }
        }

        public static int Failing(int[] grades)
        {
            int fail = 0;
            foreach (int element in grades)
            { 
                if(element == 2)
                {
                    fail++;
                }
            }

            return fail;
        }

        static void Main(string[] args)
        {
            try
            {
                //Task 1
                //The array is designed to store the height values of twelve people. Using a random number probe,
                //fill the array with integer values lying in the range from 163 to 190 inclusive.
                //Output the values of the elements using a for loop. Find the average height.

                /*int[] heights = InputHeight();
                OutputHeights(heights);
                WriteLine($"\n\nThe average height: {Average(heights)}");*/


                //Task 2
                //Fill an array of eight elements with the following values using explicit initialization: the first element of the array is 37,
                //the second is 0, the third is 50, the fourth is 46, the fifth is 34, the sixth is 46, the seventh is 0, and the eighth is -13.
                //Find the maximum and minimum elements of the array.

                /*int[] elements = InputElements();
                OutputElements(elements);
                WriteLine($"\n\nThe maximum element: {Maximum(elements)}");
                WriteLine($"\nThe minimum element: {Minimum(elements)}");*/


                //Task 3
                //Fill a one-dimensional array from the keyboard and display the array elements on the screen in reverse order.

                /*int[] array = InputArray();
                OutputArrayReverse(array);*/


                //Task 4
                //Fill a one-dimensional array randomly from -5 to 5 with integers. Increase all elements by a factor of two.
                //Output the new array values using a foreach cycle.

                /*int[] array = InputArray();
                OutputArrayx2(array);*/


                //Task 5
                //The array contains information about grades of 25 students in chemistry. Determine the number of pupils failing in chemistry.

                int[] grades = InputGrades();
                WriteLine($"Grades of 25 students in chemistry: \n");
                OutputGrades(grades);
                WriteLine($"\n\nFailing students in chemistry: {Failing(grades)}"); 


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
