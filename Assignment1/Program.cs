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

            bool q6 = ContainsDuplicate(new char[] { 'a', 'b', 'c', 'a', 'b', 'c' }, 2);
            Console.WriteLine(q6);
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



            return nums2;
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

