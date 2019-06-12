using System;
using BenchmarkDotNet.Running;

namespace ArrayLoopSurvey
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<IntArrayAccessBenchmark>();

			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();

			BenchmarkRunner.Run<LongArrayAccessBenchmark>();
		}
	}
}
