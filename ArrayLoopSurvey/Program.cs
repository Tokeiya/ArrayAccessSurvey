using System;
using BenchmarkDotNet.Running;

namespace ArrayLoopSurvey
{
	class Program
	{
		static void Main(string[] args)
		{
			var intB = new IntArrayAccessBenchmark();
			Console.WriteLine($"for:{intB.IntSumFor()}");
			Console.WriteLine($"foreach:{intB.IntSumFor()}");

			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();

			BenchmarkRunner.Run<IntArrayAccessBenchmark>();
		}
	}
}
