using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 - Sean

            Console.WriteLine("Enter 5 numbers:");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());
            int number_C = Convert.ToInt32(Console.ReadLine());
            int number_D = Convert.ToInt32(Console.ReadLine());
            int number_E = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[] array = { number_A, number_B, number_C, number_D, number_E };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter target variable");
            int target_var = Convert.ToInt32(Console.ReadLine());

            int[] q1 = TargetRange(array, target_var);
            WriteArray(q1);

            //2 - Sean

            Console.ReadLine();

            string inputString = " University";
            string inputString_1 = "of";
            string inputString_2 = "South";
            string inputString_3 = "Florida";

            string outputString = ReverseString(inputString);
            string outputString_1 = ReverseString_1(inputString_1);
            string outputString_2 = ReverseString_2(inputString_2);
            string outputString_3 = ReverseString_3(inputString_3);


            Console.Write(inputString + " " + inputString_1 + " " + inputString_2 + " " + inputString_3);
            Console.WriteLine();
            Console.Write(outputString + " " + outputString_1 + " " + outputString_2 + " " + outputString_3);

            Console.ReadLine();

            /* Question 3: Minimum sum and array */

            int[] arr = new int[] { 1, 1, 3, 4, 5, 6, 6, 8 };
            int retval = minSum(arr);
            Console.WriteLine("[{0}]", string.Join(", ", retval));

            /* Question 4: Frequency Sort */

            Console.WriteLine("enter a string");
            string name1 = Console.ReadLine();
            FreqSort(name1);

            //Q5 testing arrays
            int[] q51 = Intersect1(new int[] { 2, 5, 5, 2 }, new int[] { 5, 5 });
            Console.Write("Intersection Array: ");
            WriteArray(q51);
            int[] q52 = Intersect1(new int[] { 3, 6, 2 }, new int[] { 6, 3, 6, 7, 3 });
            Console.Write("Intersection Array: ");
            WriteArray(q52);
            int[] q53 = Intersect1(new int[] { 2, 3, 4 }, new int[] { 5, 6 });
            Console.Write("Intersection Array: ");
            WriteArray(q53);

            q51 = Intersect2(new int[] { 2, 5, 5, 2 }, new int[] { 5, 5 });
            Console.Write("Intersection Array: ");
            WriteArray(q51);
            q52 = Intersect2(new int[] { 3, 6, 2 }, new int[] { 6, 3, 6, 7, 3 });
            Console.Write("Intersection Array: ");
            WriteArray(q52);
            q53 = Intersect2(new int[] { 2, 3, 4 }, new int[] { 5, 6 });
            Console.Write("Intersection Array: ");
            WriteArray(q53);

            //Q6
            Console.WriteLine("Q6: Is the absolute difference between identical characters in [a,b,c,a,b,c] at most 2?");
            bool q6 = ContainsDuplicate(new char[] { 'a', 'b', 'c', 'a', 'b', 'c' }, 2);
            if (q6) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        public static int[] TargetRange(int[] marks, int target)
        {

            int[] output = new int[2];
            Console.WriteLine(target);
            try
            {
                output[0] = Array.IndexOf(marks, target);
                output[1] = Array.LastIndexOf(marks, target);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e);
            }
            // To return  to the main function
            return output;

        }
        private static string ReverseString(string inputString)
        {
            string resversedString = "";

            for (int count = inputString.Length - 1; count >= 0; count--)
            {
                resversedString += inputString[count];
            }
            return resversedString;
        }
        private static string ReverseString_1(string inputString_1)
        {
            string resversedString = "";

            for (int count = inputString_1.Length - 1; count >= 0; count--)
            {
                resversedString += inputString_1[count];
            }
            return resversedString;
        }
        private static string ReverseString_2(string inputString_2)
        {
            string resversedString = "";

            for (int count = inputString_2.Length - 1; count >= 0; count--)
            {
                resversedString += inputString_2[count];
            }
            return resversedString;
        }
        private static string ReverseString_3(string inputString_3)
        {
            string resversedString = "";

            for (int count = inputString_3.Length - 1; count >= 0; count--)
            {
                resversedString += inputString_3[count];
            }
            return resversedString;
        }

        public static void WriteArray(int[] arr)
        {
            if (arr.Length == 0) Console.WriteLine("Zero Length Array");
            else
            {
                Console.Write("[");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {
                        Console.WriteLine(arr[i] + "]");
                    }
                    else Console.Write(arr[i] + ",");
                }
            }
        }

        public static int minSum(int[] arr)
        {
            /*Q3: Professor Stablein is given a sorted integer array. He needs to make the array elements distinct 
             * by increasing each value as needed, while minimizing the array sum. Professor Stablein thought this 
             * was an interesting exercise that the students might enjoy completing. Your job is to complete the method 
             * to print the minimum possible sum as output.*/
            int[] output = new int[arr.Length];
            //Console.Write("Please enter the Number to find: ");
            int sum = 0;
            int temp = 0;
            // parsing to specific data types
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            try
            {
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    if (i == 0 || arr[i] != temp)
                    {
                        sum += arr[i];
                        temp = arr[i];
                        output[i] = temp;
                    }
                    else if (arr[i] == temp & temp != 0)
                    {
                        sum += arr[i] + 1;
                        temp = arr[i] + 1;
                        output[i] = temp;
                    }
                }
                Console.WriteLine("Minimum sum is :" + sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e);
            }

            Console.WriteLine("[{0}]", string.Join(", ", output));

            // To return  to the main function
            return sum;
        }

        public static void FreqSort(string name)
        {
            /*Q4: You are given a string and your task is to sort the given string in 
             * decreasing order of frequency of occurrence of each character*/
            Program p = new Program();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict = p.getCount(name);
            foreach (KeyValuePair<char, int> pair in dict.OrderByDescending(i => i.Value))
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    Console.Write(pair.Key.ToString());
                }
            }
            Console.ReadLine();
        }
        public Dictionary<char, int> getCount(string name)
        {
            return name.GroupBy(x => x).ToDictionary(gr => gr.Key, gr => gr.Count());
        }


        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            /*Q5: Rocky the Bull is new to programming and is having trouble understating the importance of time complexity. 
             * Professor Agrawal assigned you the job of explaining time complexity to Rocky with the example below.
             * Given two arrays, write a function to compute their intersection.*/
            Console.WriteLine("Question 5: two intersection functions showing time complexity:");

            //sort both arrays
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> output = new List<int>();
            Console.WriteLine("Input Arrays:");
            WriteArray(nums1);
            WriteArray(nums2);
            //compute intersection
            if (nums1.Length > nums2.Length)
            {
                int i = 0;
                int j = 0;
                while (j < nums2.Length)
                {
                    if (nums2[j] < nums1[i]) j++;
                    else if (nums1[i] == nums2[j])
                    {
                        output.Add(nums2[j]);
                        i++;
                        j++;
                    }
                    else
                    {
                        i++;
                        if (i == nums1.Length) break;
                    }
                }
            }
            else
            {
                int i = 0;
                int j = 0;
                while (j < nums1.Length)
                {
                    if (nums1[j] < nums2[i]) j++;
                    else if (nums2[i] == nums1[j])
                    {
                        output.Add(nums1[j]);
                        i++;
                        j++;
                    }
                    else
                    {
                        i++;
                        if (i == nums2.Length) break;
                    }
                }
            }
            return output.ToArray();
        }

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            Console.WriteLine("Intersection Function 2:");
            Dictionary<int, int> first = new Dictionary<int, int>();
            Dictionary<int, int> second = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++) first.Add(i, nums1[i]);
            for (int i = 0; i < nums2.Length; i++) second.Add(i, nums2[i]);
            Dictionary<int, int> output = new Dictionary<int, int>();
            //initialize output counter
            int outCounter = 0;

            if (first.Count > second.Count)
            {
                for (int i = 0; i < second.Count; i++)
                {
                    //if second[i] is found in first
                    if (first.ContainsValue(second[i]) == true)
                    {
                        //pull each out of first and add to output
                        foreach (KeyValuePair<int, int> kvp in first)
                        {
                            if (kvp.Value == second[i])
                            {
                                output.Add(outCounter, kvp.Value);
                                outCounter++;
                                first.Remove(kvp.Key);
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < first.Count; i++)
                {
                    //if second[i] is found in first
                    if (second.ContainsValue(first[i]) == true)
                    {
                        //pull each out of first and add to output
                        foreach (KeyValuePair<int, int> kvp in second)
                        {
                            if (kvp.Value == first[i])
                            {
                                output.Add(outCounter, kvp.Value);
                                outCounter++;
                                second.Remove(kvp.Key);
                                break;
                            }
                        }
                    }
                }
            }
            int[] outArray = new int[output.Count];
            for (int i = 0; i < outArray.Length; i++) outArray[i] = output[i];
            return outArray;
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            /*Q6: You are given an array of characters and an integer k, and are required to find out whether there 
             * are two distinct indices i and j in the array such that arr[i]=arr[j] and the absolute difference 
             * between i and j is at most k. */
            Console.WriteLine("Question 6: ");
            Dictionary<int, char> dist = new Dictionary<int, char>();

            for (int i = 0; i < arr.Length; i++)
            {
                foreach (KeyValuePair<int, char> letterPosition in dist)
                {
                    if (letterPosition.Value == arr[i])
                    {
                        if ((i - letterPosition.Key) <= k) return true;
                    }
                }
                dist.Add(i, arr[i]);

            }
            return false;
        }
    }
}

