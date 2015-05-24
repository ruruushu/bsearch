using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsearch
{
    static class Search
    {
        private static int helper(int[] arr, int val, int left, int right)
        {
            if(right < left) 
                return -1;

            int mid = (left + right) / 2;

            if (arr[mid] == val) return mid;
            else if (arr[mid] < val) return helper(arr, val, mid + 1, right);
            else return helper(arr, val, left, mid - 1);
        }

        public static int bsearch(int[] arr, int val)
        {
            int left = 0, right = arr.Length - 1;
            return helper(arr, val, left, right);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("{0}", Search.bsearch(arr, 7));
            Console.WriteLine("conflict1");
        } 
    }
}
