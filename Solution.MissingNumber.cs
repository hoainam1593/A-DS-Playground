namespace A_DS_Playground
{
	public partial class Solution
	{
		/*
		https://www.geeksforgeeks.org/problems/missing-number-in-array1416/1?page=1&sortBy=submissions

		Given an array of size n-1 such that it only contains distinct integers in the range of 1 to n. 
		Return the missing element.
		

		Examples:

		Input: n = 5, arr[] = [1,2,3,5]
		Output: 4
		Explanation : All the numbers from 1 to 5 are present except 4.

		Input: n = 2, arr[] = [1]
		Output: 2
		Explanation : All the numbers from 1 to 2 are present except 2.

		Expected Time Complexity: O(n)
		Expected Auxiliary Space: O(1)

		 */

		public int MissingNumber(int n, int[] arr)
		{
			//1 + 2 + 3 + ... + n = n(n+1)/2

			var nLong = (long)n;
			var sum = nLong * (nLong + 1) / 2;
			foreach (var i in arr)
			{
				sum -= i;
			}
			return (int)sum;
		}
	}
}
