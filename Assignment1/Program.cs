using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test code to call the first method and make sure it works.
            int[] test = TargetRange(new int[] { 1, 2, 3, 3, 4, 4, 5 }, 4);
            Console.WriteLine("[" + test[0] + "," + test[1] + "]");


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
            bool q6 = ContainsDuplicate(new char[] { 'a', 'b', 'c', 'a', 'b', 'c' }, 2);
            Console.WriteLine(q6);
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

        public static int[] TargetRange(int[] marks, int target)
        {
            /*Q1: Professor Agrawal receives an array of integer points sorted in ascending order, the task is to find the initial and final index of a given target point’s value.
            If the target point value is not found in the array of integers, return [-1,-1]
            The professor had to leave for a conference at short notice and asked you to complete the task for him. He instructed you to limit the time complexity to O(n).
            */

            int first = -1;
            int last = -1;
            bool foundIt = false;

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == target)
                {
                    if (foundIt) last = i;
                    else
                    {
                        first = i;
                        last = i;
                        foundIt = true;
                    }
                }
            }
            int[] r = new int[] { first, last };
            return r;
        }
        public static string StringReverse(string s)
        {
            /*Q2: Rocky is not aware of the inbuilt functions to split and reverse a string. He is given a string 
             * and he needs to reverse the order of characters in each word within a sentence while still preserving 
             * whitespace and initial word order. He is not allowed to use any predefined split and reverse function. 
             * He is requesting you to complete the method for him. */
            return s;
        }

        public static int minSum(int[] arr)
        {
            /*Q3: Professor Stablein is given a sorted integer array. He needs to make the array elements distinct 
             * by increasing each value as needed, while minimizing the array sum. Professor Stablein thought this 
             * was an interesting exercise that the students might enjoy completing. Your job is to complete the method 
             * to print the minimum possible sum as output.*/
            return arr[0];
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            /*Q5: Rocky the Bull is new to programming and is having trouble understating the importance of time complexity. 
             * Professor Agrawal assigned you the job of explaining time complexity to Rocky with the example below.
             * Given two arrays, write a function to compute their intersection.*/

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

