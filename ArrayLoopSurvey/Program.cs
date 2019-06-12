using BenchmarkDotNet.Running;

namespace ArrayLoopSurvey
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<IntArrayAccessBenchmark>();
			BenchmarkRunner.Run<LongArrayAccessBenchmark>();
		}
	}
}
