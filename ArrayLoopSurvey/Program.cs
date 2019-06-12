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

			var lngB = new LongArrayAccessBenchmark();
			Console.WriteLine($"for:{lngB.LongSumFor()}");
			Console.WriteLine($"foreach:{lngB.LongSumForeach()}");

			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();

			BenchmarkRunner.Run<IntArrayAccessBenchmark>();

			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();

			BenchmarkRunner.Run<LongArrayAccessBenchmark>();
		}
	}
}
