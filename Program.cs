namespace A_DS_Playground
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var solution = new Solution();
			var num = solution.MissingNumber(5, new int[] { 1, 3, 4, 5 });

			Console.WriteLine(num);
		}
	}
}